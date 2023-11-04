﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UI;

#nullable disable

namespace UI.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UI.Model.Administrator", b =>
                {
                    b.Property<int>("AdministratorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdministratorID"));

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("char(16)");

                    b.Property<string>("Phone")
                        .HasColumnType("char(10)");

                    b.Property<byte>("Role")
                        .HasColumnType("tinyint");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("char(20)");

                    b.HasKey("AdministratorID");

                    b.ToTable("Administrators");

                    b.HasData(
                        new
                        {
                            AdministratorID = 1,
                            Email = "Conggioi.pro264@gmail.com",
                            Password = "admin",
                            Phone = "0367093723",
                            Role = (byte)1,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("UI.Model.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("char(10)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("UI.Model.ExportBill", b =>
                {
                    b.Property<int>("ExportBillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExportBillID"));

                    b.Property<int>("AdministratorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("Date");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ExportBillID");

                    b.HasIndex("AdministratorID");

                    b.HasIndex("CustomerID");

                    b.ToTable("ExportBills");
                });

            modelBuilder.Entity("UI.Model.ExportBillDetail", b =>
                {
                    b.Property<int>("ExportBillDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExportBillDetailID"));

                    b.Property<int>("ExportBillID")
                        .HasColumnType("int");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.HasKey("ExportBillDetailID");

                    b.HasIndex("ExportBillID");

                    b.ToTable("ExportBillDetails");
                });

            modelBuilder.Entity("UI.Model.ExportProductDetail", b =>
                {
                    b.Property<int>("ExportProductDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExportProductDetailID"));

                    b.Property<int>("ExportBillDetailID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("StockDetailID")
                        .HasColumnType("int");

                    b.HasKey("ExportProductDetailID");

                    b.HasIndex("ExportBillDetailID");

                    b.HasIndex("StockDetailID");

                    b.ToTable("ExportProductDetails");
                });

            modelBuilder.Entity("UI.Model.ImportBill", b =>
                {
                    b.Property<int>("ImportBillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImportBillID"));

                    b.Property<int>("AdministratorID")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTimeDate")
                        .HasColumnType("Date");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("StockID")
                        .HasColumnType("int");

                    b.HasKey("ImportBillID");

                    b.HasIndex("AdministratorID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("StockID");

                    b.ToTable("ImportBills");
                });

            modelBuilder.Entity("UI.Model.ImportDetail", b =>
                {
                    b.Property<int>("ImportDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImportDetailID"));

                    b.Property<int>("ImportBillID")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ImportDetailID");

                    b.HasIndex("ImportBillID");

                    b.HasIndex("ProductID");

                    b.ToTable("ImportDetail");
                });

            modelBuilder.Entity("UI.Model.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("UnitID")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("UnitID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1L,
                            Description = "Bút bi Thiên Long 20Cây/hộp màu xanh",
                            Name = "Bút bi Thiên Long",
                            Price = 0,
                            UnitID = 1
                        },
                        new
                        {
                            ProductID = 2L,
                            Description = "Thước kẻ 20cm hộp 30 cái",
                            Name = "Thước kẻ 20cm",
                            Price = 0,
                            UnitID = 1
                        },
                        new
                        {
                            ProductID = 3L,
                            Description = "Giấy in văn phòng 1 thùng 20 xấp",
                            Name = "Giấy in văn phòng",
                            Price = 0,
                            UnitID = 3
                        },
                        new
                        {
                            ProductID = 4L,
                            Description = "Bút lông viết bảng (màu xanh) hộp 10 cái",
                            Name = "Bút lông viết bảng (màu xanh)",
                            Price = 0,
                            UnitID = 1
                        },
                        new
                        {
                            ProductID = 5L,
                            Description = "Gôm/Bút tẩy xóa",
                            Name = "Gôm/Bút tẩy xóa",
                            Price = 0,
                            UnitID = 3
                        },
                        new
                        {
                            ProductID = 6L,
                            Description = "Dao kéo, Băng keo",
                            Name = "Dao kéo, Băng keo",
                            Price = 0,
                            UnitID = 2
                        },
                        new
                        {
                            ProductID = 7L,
                            Description = "Túi đựng hồ sơ và tài liệu",
                            Name = "Túi đựng hồ sơ và tài liệu",
                            Price = 0,
                            UnitID = 2
                        },
                        new
                        {
                            ProductID = 8L,
                            Description = "Sổ tay học từ vựng",
                            Name = "Sổ tay học từ vựng",
                            Price = 0,
                            UnitID = 5
                        });
                });

            modelBuilder.Entity("UI.Model.Stock", b =>
                {
                    b.Property<int>("StockID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StockID");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("UI.Model.StockDetail", b =>
                {
                    b.Property<int>("StockDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockDetailID"));

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("StockID")
                        .HasColumnType("int");

                    b.HasKey("StockDetailID");

                    b.HasIndex("ProductID");

                    b.HasIndex("StockID");

                    b.ToTable("StockDetails");
                });

            modelBuilder.Entity("UI.Model.Unit", b =>
                {
                    b.Property<int>("UnitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UnitID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UnitID");

                    b.ToTable("Units");

                    b.HasData(
                        new
                        {
                            UnitID = 1,
                            Name = "Hộp"
                        },
                        new
                        {
                            UnitID = 2,
                            Name = "Cái"
                        },
                        new
                        {
                            UnitID = 3,
                            Name = "Thùng"
                        },
                        new
                        {
                            UnitID = 4,
                            Name = "Chiếc"
                        },
                        new
                        {
                            UnitID = 5,
                            Name = "Ram"
                        },
                        new
                        {
                            UnitID = 6,
                            Name = "Xấp"
                        });
                });

            modelBuilder.Entity("UI.Model.ExportBill", b =>
                {
                    b.HasOne("UI.Model.Administrator", "Administrator")
                        .WithMany("exportBills")
                        .HasForeignKey("AdministratorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UI.Model.Customer", "Customer")
                        .WithMany("exportBills")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administrator");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("UI.Model.ExportBillDetail", b =>
                {
                    b.HasOne("UI.Model.ExportBill", "ExportBill")
                        .WithMany()
                        .HasForeignKey("ExportBillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExportBill");
                });

            modelBuilder.Entity("UI.Model.ExportProductDetail", b =>
                {
                    b.HasOne("UI.Model.ExportBillDetail", "ExportBillDetail")
                        .WithMany("exportProductDetails")
                        .HasForeignKey("ExportBillDetailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UI.Model.StockDetail", "StockDetail")
                        .WithMany("ExportProducts")
                        .HasForeignKey("StockDetailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExportBillDetail");

                    b.Navigation("StockDetail");
                });

            modelBuilder.Entity("UI.Model.ImportBill", b =>
                {
                    b.HasOne("UI.Model.Administrator", "Administrator")
                        .WithMany("ImportBills")
                        .HasForeignKey("AdministratorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UI.Model.Customer", null)
                        .WithMany("importBills")
                        .HasForeignKey("CustomerID");

                    b.HasOne("UI.Model.Stock", "Stock")
                        .WithMany("ImportBill")
                        .HasForeignKey("StockID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administrator");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("UI.Model.ImportDetail", b =>
                {
                    b.HasOne("UI.Model.ImportBill", "ImportBill")
                        .WithMany("ImportDetails")
                        .HasForeignKey("ImportBillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UI.Model.Product", "Product")
                        .WithMany("ImportDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ImportBill");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("UI.Model.Product", b =>
                {
                    b.HasOne("UI.Model.Unit", "Unit")
                        .WithMany("Products")
                        .HasForeignKey("UnitID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("UI.Model.StockDetail", b =>
                {
                    b.HasOne("UI.Model.Product", "Product")
                        .WithMany("StockDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UI.Model.Stock", "Stock")
                        .WithMany("StockDetails")
                        .HasForeignKey("StockID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("UI.Model.Administrator", b =>
                {
                    b.Navigation("ImportBills");

                    b.Navigation("exportBills");
                });

            modelBuilder.Entity("UI.Model.Customer", b =>
                {
                    b.Navigation("exportBills");

                    b.Navigation("importBills");
                });

            modelBuilder.Entity("UI.Model.ExportBillDetail", b =>
                {
                    b.Navigation("exportProductDetails");
                });

            modelBuilder.Entity("UI.Model.ImportBill", b =>
                {
                    b.Navigation("ImportDetails");
                });

            modelBuilder.Entity("UI.Model.Product", b =>
                {
                    b.Navigation("ImportDetails");

                    b.Navigation("StockDetails");
                });

            modelBuilder.Entity("UI.Model.Stock", b =>
                {
                    b.Navigation("ImportBill");

                    b.Navigation("StockDetails");
                });

            modelBuilder.Entity("UI.Model.StockDetail", b =>
                {
                    b.Navigation("ExportProducts");
                });

            modelBuilder.Entity("UI.Model.Unit", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
