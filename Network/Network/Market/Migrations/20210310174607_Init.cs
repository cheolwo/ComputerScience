using Microsoft.EntityFrameworkCore.Migrations;

namespace Market.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SCommodities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageRoute = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCommodities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetailsofCommodity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_DetailsofCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailsofCommodity_SCommodities_CommodityNo",
                        column: x => x.CommodityNo,
                        principalTable: "SCommodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    SCommodityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_SCommodities_SCommodityId",
                        column: x => x.SCommodityId,
                        principalTable: "SCommodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetailImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageRoute = table.Column<string>(nullable: true),
                    DetailofSCommodityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailImages_DetailsofCommodity_DetailofSCommodityId",
                        column: x => x.DetailofSCommodityId,
                        principalTable: "DetailsofCommodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Docs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameofDoc = table.Column<string>(nullable: true),
                    DocRoute = table.Column<string>(nullable: true),
                    DetailofSCommodityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Docs_DetailsofCommodity_DetailofSCommodityId",
                        column: x => x.DetailofSCommodityId,
                        principalTable: "DetailsofCommodity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageofOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageRoute = table.Column<string>(nullable: true),
                    OptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageofOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageofOptions_Options_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Options",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageofDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageRoute = table.Column<string>(nullable: true),
                    ImageofOptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageofDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageofDetails_ImageofOptions_ImageofOptionId",
                        column: x => x.ImageofOptionId,
                        principalTable: "ImageofOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailImages_DetailofSCommodityId",
                table: "DetailImages",
                column: "DetailofSCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailsofCommodity_CommodityNo",
                table: "DetailsofCommodity",
                column: "CommodityNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Docs_DetailofSCommodityId",
                table: "Docs",
                column: "DetailofSCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageofDetails_ImageofOptionId",
                table: "ImageofDetails",
                column: "ImageofOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageofOptions_OptionId",
                table: "ImageofOptions",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_SCommodityId",
                table: "Options",
                column: "SCommodityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailImages");

            migrationBuilder.DropTable(
                name: "Docs");

            migrationBuilder.DropTable(
                name: "ImageofDetails");

            migrationBuilder.DropTable(
                name: "DetailsofCommodity");

            migrationBuilder.DropTable(
                name: "ImageofOptions");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "SCommodities");
        }
    }
}
