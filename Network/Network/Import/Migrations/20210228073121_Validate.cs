using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Import.Migrations
{
    public partial class Validate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Commodities_CommodityNo",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "ImageofOptions");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "ImageofDetails");

            migrationBuilder.DropColumn(
                name: "Document",
                table: "Docs");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Options",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SalePrice",
                table: "Options",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalPrice",
                table: "Options",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Options",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CommodityNo",
                table: "Options",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageRoute",
                table: "ImageofOptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageRoute",
                table: "ImageofDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocRoute",
                table: "Docs",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Commodities_CommodityNo",
                table: "Options",
                column: "CommodityNo",
                principalTable: "Commodities",
                principalColumn: "CommodityNo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Commodities_CommodityNo",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "ImageRoute",
                table: "ImageofOptions");

            migrationBuilder.DropColumn(
                name: "ImageRoute",
                table: "ImageofDetails");

            migrationBuilder.DropColumn(
                name: "DocRoute",
                table: "Docs");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Options",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "SalePrice",
                table: "Options",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NormalPrice",
                table: "Options",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Options",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "CommodityNo",
                table: "Options",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "ImageofOptions",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "ImageofDetails",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Document",
                table: "Docs",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Commodities_CommodityNo",
                table: "Options",
                column: "CommodityNo",
                principalTable: "Commodities",
                principalColumn: "CommodityNo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
