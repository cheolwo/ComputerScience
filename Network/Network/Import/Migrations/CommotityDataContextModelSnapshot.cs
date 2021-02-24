﻿// <auto-generated />
using System;
using Import.ImportDataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Import.Migrations
{
    [DbContext(typeof(CommotityDataContext))]
    partial class CommotityDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Import.Model.Commodity", b =>
                {
                    b.Property<int>("CommodityNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CommotityDetail")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommodityNo");

                    b.HasIndex("CommotityDetail");

                    b.ToTable("Commodities");
                });

            modelBuilder.Entity("Import.Model.CommodityDetail", b =>
                {
                    b.Property<int>("CommodityDetailNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Authenticate")
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Commotity")
                        .HasColumnType("int");

                    b.Property<DateTime>("DurationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Import")
                        .HasColumnType("int");

                    b.Property<bool>("IsVAT")
                        .HasColumnType("bit");

                    b.Property<int>("MaximumPossibleQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Menufactured")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PossibleUnder20")
                        .HasColumnType("bit");

                    b.Property<string>("WarehouseCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommodityDetailNo");

                    b.HasIndex("Commotity");

                    b.ToTable("CommodityDetails");
                });

            modelBuilder.Entity("Import.Model.Doc", b =>
                {
                    b.Property<int>("DocNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CommodityDetailNo")
                        .HasColumnType("int");

                    b.Property<byte[]>("Document")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NameofDoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocNo");

                    b.HasIndex("CommodityDetailNo");

                    b.ToTable("Docs");
                });

            modelBuilder.Entity("Import.Model.Image", b =>
                {
                    b.Property<int>("ImageNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("ImageDataofDetail")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageTitieofDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OptionNo")
                        .HasColumnType("int");

                    b.HasKey("ImageNo");

                    b.HasIndex("OptionNo");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Import.Model.Option", b =>
                {
                    b.Property<int>("OptionNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CommodityNo")
                        .HasColumnType("int");

                    b.Property<string>("CommotityBarcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SalePrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerCodeofCommodity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OptionNo");

                    b.HasIndex("CommodityNo");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("Import.Model.Commodity", b =>
                {
                    b.HasOne("Import.Model.CommodityDetail", "CommodityDetail")
                        .WithMany()
                        .HasForeignKey("CommotityDetail");
                });

            modelBuilder.Entity("Import.Model.CommodityDetail", b =>
                {
                    b.HasOne("Import.Model.Commodity", "Commodity")
                        .WithMany()
                        .HasForeignKey("Commotity");
                });

            modelBuilder.Entity("Import.Model.Doc", b =>
                {
                    b.HasOne("Import.Model.CommodityDetail", "CommodityDetail")
                        .WithMany("Docs")
                        .HasForeignKey("CommodityDetailNo");
                });

            modelBuilder.Entity("Import.Model.Image", b =>
                {
                    b.HasOne("Import.Model.Option", "Option")
                        .WithMany("Images")
                        .HasForeignKey("OptionNo");
                });

            modelBuilder.Entity("Import.Model.Option", b =>
                {
                    b.HasOne("Import.Model.Commodity", "Commodity")
                        .WithMany("Options")
                        .HasForeignKey("CommodityNo");
                });
#pragma warning restore 612, 618
        }
    }
}
