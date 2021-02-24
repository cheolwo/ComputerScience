using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Import.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommodityDetails",
                columns: table => new
                {
                    CommodityDetailNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    Menufactured = table.Column<string>(nullable: true),
                    Authenticate = table.Column<int>(nullable: false),
                    Import = table.Column<int>(nullable: false),
                    PossibleUnder20 = table.Column<bool>(nullable: false),
                    MaximumPossibleQuantity = table.Column<int>(nullable: false),
                    DurationTime = table.Column<DateTime>(nullable: false),
                    IsVAT = table.Column<bool>(nullable: false),
                    WarehouseCode = table.Column<string>(nullable: true),
                    Commotity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityDetails", x => x.CommodityDetailNo);
                });

            migrationBuilder.CreateTable(
                name: "Commodities",
                columns: table => new
                {
                    CommodityNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    CommotityDetail = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodities", x => x.CommodityNo);
                    table.ForeignKey(
                        name: "FK_Commodities_CommodityDetails_CommotityDetail",
                        column: x => x.CommotityDetail,
                        principalTable: "CommodityDetails",
                        principalColumn: "CommodityDetailNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Docs",
                columns: table => new
                {
                    DocNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameofDoc = table.Column<string>(nullable: true),
                    Document = table.Column<byte[]>(nullable: true),
                    CommodityDetailNo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docs", x => x.DocNo);
                    table.ForeignKey(
                        name: "FK_Docs_CommodityDetails_CommodityDetailNo",
                        column: x => x.CommodityDetailNo,
                        principalTable: "CommodityDetails",
                        principalColumn: "CommodityDetailNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    OptionNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    CommodityNo = table.Column<int>(nullable: true),
                    NormalPrice = table.Column<string>(nullable: true),
                    SalePrice = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    SellerCodeofCommodity = table.Column<string>(nullable: true),
                    ModelNo = table.Column<string>(nullable: true),
                    CommotityBarcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.OptionNo);
                    table.ForeignKey(
                        name: "FK_Options_Commodities_CommodityNo",
                        column: x => x.CommodityNo,
                        principalTable: "Commodities",
                        principalColumn: "CommodityNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageData = table.Column<byte[]>(nullable: true),
                    ImageTitieofDetail = table.Column<string>(nullable: true),
                    ImageDataofDetail = table.Column<byte[]>(nullable: true),
                    OptionNo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageNo);
                    table.ForeignKey(
                        name: "FK_Images_Options_OptionNo",
                        column: x => x.OptionNo,
                        principalTable: "Options",
                        principalColumn: "OptionNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commodities_CommotityDetail",
                table: "Commodities",
                column: "CommotityDetail");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityDetails_Commotity",
                table: "CommodityDetails",
                column: "Commotity");

            migrationBuilder.CreateIndex(
                name: "IX_Docs_CommodityDetailNo",
                table: "Docs",
                column: "CommodityDetailNo");

            migrationBuilder.CreateIndex(
                name: "IX_Images_OptionNo",
                table: "Images",
                column: "OptionNo");

            migrationBuilder.CreateIndex(
                name: "IX_Options_CommodityNo",
                table: "Options",
                column: "CommodityNo");

            migrationBuilder.AddForeignKey(
                name: "FK_CommodityDetails_Commodities_Commotity",
                table: "CommodityDetails",
                column: "Commotity",
                principalTable: "Commodities",
                principalColumn: "CommodityNo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commodities_CommodityDetails_CommotityDetail",
                table: "Commodities");

            migrationBuilder.DropTable(
                name: "Docs");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "CommodityDetails");

            migrationBuilder.DropTable(
                name: "Commodities");
        }
    }
}
