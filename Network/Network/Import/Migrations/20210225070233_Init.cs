using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Import.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commodities",
                columns: table => new
                {
                    CommodityNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodities", x => x.CommodityNo);
                });

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
                    CommodityNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityDetails", x => x.CommodityDetailNo);
                    table.ForeignKey(
                        name: "FK_CommodityDetails_Commodities_CommodityNo",
                        column: x => x.CommodityNo,
                        principalTable: "Commodities",
                        principalColumn: "CommodityNo",
                        onDelete: ReferentialAction.Cascade);
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
                name: "ImageofDetails",
                columns: table => new
                {
                    ImageNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageData = table.Column<byte[]>(nullable: true),
                    CommodityDetailNo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageofDetails", x => x.ImageNo);
                    table.ForeignKey(
                        name: "FK_ImageofDetails_CommodityDetails_CommodityDetailNo",
                        column: x => x.CommodityDetailNo,
                        principalTable: "CommodityDetails",
                        principalColumn: "CommodityDetailNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageofOptions",
                columns: table => new
                {
                    ImageNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageData = table.Column<byte[]>(nullable: true),
                    OptionNo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageofOptions", x => x.ImageNo);
                    table.ForeignKey(
                        name: "FK_ImageofOptions_Options_OptionNo",
                        column: x => x.OptionNo,
                        principalTable: "Options",
                        principalColumn: "OptionNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommodityDetails_CommodityNo",
                table: "CommodityDetails",
                column: "CommodityNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Docs_CommodityDetailNo",
                table: "Docs",
                column: "CommodityDetailNo");

            migrationBuilder.CreateIndex(
                name: "IX_ImageofDetails_CommodityDetailNo",
                table: "ImageofDetails",
                column: "CommodityDetailNo");

            migrationBuilder.CreateIndex(
                name: "IX_ImageofOptions_OptionNo",
                table: "ImageofOptions",
                column: "OptionNo");

            migrationBuilder.CreateIndex(
                name: "IX_Options_CommodityNo",
                table: "Options",
                column: "CommodityNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Docs");

            migrationBuilder.DropTable(
                name: "ImageofDetails");

            migrationBuilder.DropTable(
                name: "ImageofOptions");

            migrationBuilder.DropTable(
                name: "CommodityDetails");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Commodities");
        }
    }
}
