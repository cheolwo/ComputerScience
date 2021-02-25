using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Import.Migrations
{
    public partial class Image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Commodities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageTitle",
                table: "Commodities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Commodities");

            migrationBuilder.DropColumn(
                name: "ImageTitle",
                table: "Commodities");
        }
    }
}
