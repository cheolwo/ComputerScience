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

            modelBuilder.Entity("Import.Model.Buying", b =>
                {
                    b.Property<int>("SellNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CommodityNo")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyofBuyingSellerNo")
                        .HasColumnType("int");

                    b.Property<double>("Money")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("SellNo");

                    b.HasIndex("CommodityNo");

                    b.HasIndex("CompanyofBuyingSellerNo");

                    b.ToTable("Buyings");
                });

            modelBuilder.Entity("Import.Model.Commodity", b =>
                {
                    b.Property<int>("CommodityNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageRoute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommodityNo");

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

                    b.Property<int>("CommodityNo")
                        .HasColumnType("int");

                    b.Property<int>("DurationTime")
                        .HasColumnType("int");

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

                    b.Property<int>("WarehouseNo")
                        .HasColumnType("int");

                    b.HasKey("CommodityDetailNo");

                    b.HasIndex("CommodityNo")
                        .IsUnique();

                    b.ToTable("CommodityDetails");
                });

            modelBuilder.Entity("Import.Model.CompanyofBuying", b =>
                {
                    b.Property<int>("SellerNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SellerNo");

                    b.ToTable("CompanyofBuyings");
                });

            modelBuilder.Entity("Import.Model.DetailImage", b =>
                {
                    b.Property<int>("DetailImageNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CommodityDetailNo")
                        .HasColumnType("int");

                    b.Property<string>("ImageRoute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DetailImageNo");

                    b.HasIndex("CommodityDetailNo");

                    b.ToTable("DetailImages");
                });

            modelBuilder.Entity("Import.Model.Doc", b =>
                {
                    b.Property<int>("DocNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CommodityDetailNo")
                        .HasColumnType("int");

                    b.Property<string>("DocRoute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameofDoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocNo");

                    b.HasIndex("CommodityDetailNo");

                    b.ToTable("Docs");
                });

            modelBuilder.Entity("Import.Model.ImageofDetail", b =>
                {
                    b.Property<int>("ImageNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageRoute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ImageofOptionImageNo")
                        .HasColumnType("int");

                    b.HasKey("ImageNo");

                    b.HasIndex("ImageofOptionImageNo");

                    b.ToTable("ImageofDetails");
                });

            modelBuilder.Entity("Import.Model.ImageofOption", b =>
                {
                    b.Property<int>("ImageNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageRoute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OptionNo")
                        .HasColumnType("int");

                    b.HasKey("ImageNo");

                    b.HasIndex("OptionNo");

                    b.ToTable("ImageofOptions");
                });

            modelBuilder.Entity("Import.Model.Option", b =>
                {
                    b.Property<int>("OptionNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CommodityNo")
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OptionNo");

                    b.HasIndex("CommodityNo");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("Import.Model.Buying", b =>
                {
                    b.HasOne("Import.Model.Commodity", "Commodity")
                        .WithMany()
                        .HasForeignKey("CommodityNo");

                    b.HasOne("Import.Model.CompanyofBuying", "CompanyofBuying")
                        .WithMany("Buyings")
                        .HasForeignKey("CompanyofBuyingSellerNo");
                });

            modelBuilder.Entity("Import.Model.CommodityDetail", b =>
                {
                    b.HasOne("Import.Model.Commodity", "Commodity")
                        .WithOne("CommodityDetail")
                        .HasForeignKey("Import.Model.CommodityDetail", "CommodityNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Import.Model.DetailImage", b =>
                {
                    b.HasOne("Import.Model.CommodityDetail", "CommodityDetail")
                        .WithMany("DetailImages")
                        .HasForeignKey("CommodityDetailNo");
                });

            modelBuilder.Entity("Import.Model.Doc", b =>
                {
                    b.HasOne("Import.Model.CommodityDetail", "CommodityDetail")
                        .WithMany("Docs")
                        .HasForeignKey("CommodityDetailNo");
                });

            modelBuilder.Entity("Import.Model.ImageofDetail", b =>
                {
                    b.HasOne("Import.Model.ImageofOption", "ImageofOption")
                        .WithMany("ImagesofDetail")
                        .HasForeignKey("ImageofOptionImageNo");
                });

            modelBuilder.Entity("Import.Model.ImageofOption", b =>
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
