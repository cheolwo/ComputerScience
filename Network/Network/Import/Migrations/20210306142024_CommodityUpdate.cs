using Microsoft.EntityFrameworkCore.Migrations;

namespace Import.Migrations
{
    public partial class CommodityUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Commodities_CommodityNo",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "CommotityBarcode",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "ModelNo",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "NormalPrice",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "SalePrice",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "SellerCodeofCommodity",
                table: "Options");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Options",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "Options",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CommodityNo",
                table: "Options",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Commodities",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "DetailImages",
                columns: table => new
                {
                    DetailImageNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageRoute = table.Column<string>(nullable: true),
                    CommodityDetailNo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailImages", x => x.DetailImageNo);
                    table.ForeignKey(
                        name: "FK_DetailImages_CommodityDetails_CommodityDetailNo",
                        column: x => x.CommodityDetailNo,
                        principalTable: "CommodityDetails",
                        principalColumn: "CommodityDetailNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailImages_CommodityDetailNo",
                table: "DetailImages",
                column: "CommodityDetailNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Commodities_CommodityNo",
                table: "Options",
                column: "CommodityNo",
                principalTable: "Commodities",
                principalColumn: "CommodityNo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Commodities_CommodityNo",
                table: "Options");

            migrationBuilder.DropTable(
                name: "DetailImages");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Options",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "Options",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CommodityNo",
                table: "Options",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommotityBarcode",
                table: "Options",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModelNo",
                table: "Options",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalPrice",
                table: "Options",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Options",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SalePrice",
                table: "Options",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SellerCodeofCommodity",
                table: "Options",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Commodities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Commodities_CommodityNo",
                table: "Options",
                column: "CommodityNo",
                principalTable: "Commodities",
                principalColumn: "CommodityNo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
