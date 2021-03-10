using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Country = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncomingTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeName = table.Column<string>(nullable: true),
                    Attached = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomingTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Width = table.Column<double>(nullable: false),
                    height = table.Column<double>(nullable: false),
                    length = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImagesofBase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageRoute = table.Column<string>(nullable: true),
                    BaseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesofBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagesofBase_Bases_BaseId",
                        column: x => x.BaseId,
                        principalTable: "Bases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoadFrames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    BaseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoadFrames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoadFrames_Bases_BaseId",
                        column: x => x.BaseId,
                        principalTable: "Bases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WCommodities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Barcode = table.Column<string>(nullable: true),
                    Width = table.Column<double>(nullable: true),
                    height = table.Column<double>(nullable: true),
                    length = table.Column<double>(nullable: true),
                    TCommodityId = table.Column<int>(nullable: false),
                    Purpose = table.Column<string>(nullable: true),
                    StateofIncoming = table.Column<int>(nullable: false),
                    IncomingTime = table.Column<DateTime>(nullable: true),
                    InspectingTime = table.Column<DateTime>(nullable: true),
                    LoadingTime = table.Column<DateTime>(nullable: true),
                    IncomingUser = table.Column<string>(nullable: true),
                    InspectingUser = table.Column<string>(nullable: true),
                    IncomingQuantity = table.Column<int>(nullable: false),
                    OutgoingQuantity = table.Column<int>(nullable: false),
                    IncomingTag = table.Column<string>(nullable: true),
                    BaseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WCommodities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WCommodities_Bases_BaseId",
                        column: x => x.BaseId,
                        principalTable: "Bases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DividedTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeName = table.Column<string>(nullable: true),
                    Attached = table.Column<bool>(nullable: false),
                    IncomingTagId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DividedTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DividedTags_IncomingTags_IncomingTagId",
                        column: x => x.IncomingTagId,
                        principalTable: "IncomingTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImagesofPack",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitie = table.Column<string>(nullable: true),
                    ImageRoute = table.Column<string>(nullable: true),
                    PackId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesofPack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagesofPack_Packs_PackId",
                        column: x => x.PackId,
                        principalTable: "Packs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DividedCommodities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagfDividing = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    LoadFrmaeId = table.Column<int>(nullable: true),
                    WCommodityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DividedCommodities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DividedCommodities_LoadFrames_LoadFrmaeId",
                        column: x => x.LoadFrmaeId,
                        principalTable: "LoadFrames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DividedCommodities_WCommodities_WCommodityId",
                        column: x => x.WCommodityId,
                        principalTable: "WCommodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImagesofIncoming",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Route = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    WCommodityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesofIncoming", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagesofIncoming_WCommodities_WCommodityId",
                        column: x => x.WCommodityId,
                        principalTable: "WCommodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImagesofWCommodity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Route = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    WCommodityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesofWCommodity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagesofWCommodity_WCommodities_WCommodityId",
                        column: x => x.WCommodityId,
                        principalTable: "WCommodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OutgoingCommodities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    StateofOutgoing = table.Column<int>(nullable: false),
                    WaitingTime = table.Column<DateTime>(nullable: true),
                    PickingTime = table.Column<DateTime>(nullable: true),
                    PackingTime = table.Column<DateTime>(nullable: true),
                    OutgoingTime = table.Column<DateTime>(nullable: true),
                    DeliveringTime = table.Column<DateTime>(nullable: true),
                    PickingUser = table.Column<string>(nullable: true),
                    PackingUser = table.Column<string>(nullable: true),
                    OutgoingUser = table.Column<string>(nullable: true),
                    DeliveringUser = table.Column<string>(nullable: true),
                    PackId = table.Column<int>(nullable: true),
                    WCommodityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutgoingCommodities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutgoingCommodities_Packs_PackId",
                        column: x => x.PackId,
                        principalTable: "Packs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutgoingCommodities_WCommodities_WCommodityId",
                        column: x => x.WCommodityId,
                        principalTable: "WCommodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImagesofLoading",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Route = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    DividedCommodityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesofLoading", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagesofLoading_DividedCommodities_DividedCommodityId",
                        column: x => x.DividedCommodityId,
                        principalTable: "DividedCommodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageofPacking",
                columns: table => new
                {
                    ImageNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Route = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: true),
                    OutgoingCommodityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageofPacking", x => x.ImageNo);
                    table.ForeignKey(
                        name: "FK_ImageofPacking_OutgoingCommodities_OutgoingCommodityId",
                        column: x => x.OutgoingCommodityId,
                        principalTable: "OutgoingCommodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImagesofDelivering",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Route = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    OutgoingCommodityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesofDelivering", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagesofDelivering_OutgoingCommodities_OutgoingCommodityId",
                        column: x => x.OutgoingCommodityId,
                        principalTable: "OutgoingCommodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImagesofOutgoing",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Route = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    OutgoingCommodityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesofOutgoing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagesofOutgoing_OutgoingCommodities_OutgoingCommodityId",
                        column: x => x.OutgoingCommodityId,
                        principalTable: "OutgoingCommodities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DividedCommodities_LoadFrmaeId",
                table: "DividedCommodities",
                column: "LoadFrmaeId");

            migrationBuilder.CreateIndex(
                name: "IX_DividedCommodities_WCommodityId",
                table: "DividedCommodities",
                column: "WCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_DividedTags_IncomingTagId",
                table: "DividedTags",
                column: "IncomingTagId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageofPacking_OutgoingCommodityId",
                table: "ImageofPacking",
                column: "OutgoingCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesofBase_BaseId",
                table: "ImagesofBase",
                column: "BaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesofDelivering_OutgoingCommodityId",
                table: "ImagesofDelivering",
                column: "OutgoingCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesofIncoming_WCommodityId",
                table: "ImagesofIncoming",
                column: "WCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesofLoading_DividedCommodityId",
                table: "ImagesofLoading",
                column: "DividedCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesofOutgoing_OutgoingCommodityId",
                table: "ImagesofOutgoing",
                column: "OutgoingCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesofPack_PackId",
                table: "ImagesofPack",
                column: "PackId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesofWCommodity_WCommodityId",
                table: "ImagesofWCommodity",
                column: "WCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadFrames_BaseId",
                table: "LoadFrames",
                column: "BaseId");

            migrationBuilder.CreateIndex(
                name: "IX_OutgoingCommodities_PackId",
                table: "OutgoingCommodities",
                column: "PackId");

            migrationBuilder.CreateIndex(
                name: "IX_OutgoingCommodities_WCommodityId",
                table: "OutgoingCommodities",
                column: "WCommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_WCommodities_BaseId",
                table: "WCommodities",
                column: "BaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DividedTags");

            migrationBuilder.DropTable(
                name: "ImageofPacking");

            migrationBuilder.DropTable(
                name: "ImagesofBase");

            migrationBuilder.DropTable(
                name: "ImagesofDelivering");

            migrationBuilder.DropTable(
                name: "ImagesofIncoming");

            migrationBuilder.DropTable(
                name: "ImagesofLoading");

            migrationBuilder.DropTable(
                name: "ImagesofOutgoing");

            migrationBuilder.DropTable(
                name: "ImagesofPack");

            migrationBuilder.DropTable(
                name: "ImagesofWCommodity");

            migrationBuilder.DropTable(
                name: "IncomingTags");

            migrationBuilder.DropTable(
                name: "DividedCommodities");

            migrationBuilder.DropTable(
                name: "OutgoingCommodities");

            migrationBuilder.DropTable(
                name: "LoadFrames");

            migrationBuilder.DropTable(
                name: "Packs");

            migrationBuilder.DropTable(
                name: "WCommodities");

            migrationBuilder.DropTable(
                name: "Bases");
        }
    }
}
