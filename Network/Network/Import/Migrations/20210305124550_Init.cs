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
                    Url = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageRoute = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodities", x => x.CommodityNo);
                });

            migrationBuilder.CreateTable(
                name: "CompanyofBuyings",
                columns: table => new
                {
                    SellerNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyofBuyings", x => x.SellerNo);
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
                    DurationTime = table.Column<int>(nullable: false),
                    IsVAT = table.Column<bool>(nullable: false),
                    WarehouseNo = table.Column<int>(nullable: false),
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
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false),
                    CommodityNo = table.Column<int>(nullable: false),
                    NormalPrice = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    SalePrice = table.Column<string>(nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Buyings",
                columns: table => new
                {
                    SellNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false),
                    Money = table.Column<double>(nullable: false),
                    CompanyofBuyingSellerNo = table.Column<int>(nullable: true),
                    CommodityNo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyings", x => x.SellNo);
                    table.ForeignKey(
                        name: "FK_Buyings_Commodities_CommodityNo",
                        column: x => x.CommodityNo,
                        principalTable: "Commodities",
                        principalColumn: "CommodityNo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Buyings_CompanyofBuyings_CompanyofBuyingSellerNo",
                        column: x => x.CompanyofBuyingSellerNo,
                        principalTable: "CompanyofBuyings",
                        principalColumn: "SellerNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Docs",
                columns: table => new
                {
                    DocNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameofDoc = table.Column<string>(nullable: true),
                    DocRoute = table.Column<string>(nullable: true),
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
                name: "ImageofOptions",
                columns: table => new
                {
                    ImageNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageRoute = table.Column<string>(nullable: true),
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

            migrationBuilder.CreateTable(
                name: "ImageofDetails",
                columns: table => new
                {
                    ImageNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageRoute = table.Column<string>(nullable: true),
                    ImageofOptionImageNo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageofDetails", x => x.ImageNo);
                    table.ForeignKey(
                        name: "FK_ImageofDetails_ImageofOptions_ImageofOptionImageNo",
                        column: x => x.ImageofOptionImageNo,
                        principalTable: "ImageofOptions",
                        principalColumn: "ImageNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buyings_CommodityNo",
                table: "Buyings",
                column: "CommodityNo");

            migrationBuilder.CreateIndex(
                name: "IX_Buyings_CompanyofBuyingSellerNo",
                table: "Buyings",
                column: "CompanyofBuyingSellerNo");

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
                name: "IX_ImageofDetails_ImageofOptionImageNo",
                table: "ImageofDetails",
                column: "ImageofOptionImageNo");

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
                name: "Buyings");

            migrationBuilder.DropTable(
                name: "Docs");

            migrationBuilder.DropTable(
                name: "ImageofDetails");

            migrationBuilder.DropTable(
                name: "CompanyofBuyings");

            migrationBuilder.DropTable(
                name: "CommodityDetails");

            migrationBuilder.DropTable(
                name: "ImageofOptions");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Commodities");
        }
    }
}
