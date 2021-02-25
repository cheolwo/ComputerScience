using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Import.Migrations
{
    public partial class ImageRoute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Commodities");

            migrationBuilder.AddColumn<string>(
                name: "ImageRoute",
                table: "Commodities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageRoute",
                table: "Commodities");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Commodities",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
