﻿// <auto-generated />
using System;
using Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(CodeDbContext))]
    [Migration("20220318083545_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Data.Entiti.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("AppConfig", (string)null);

                    b.HasData(
                        new
                        {
                            Key = "HomeTitle",
                            Value = "This is home page of "
                        },
                        new
                        {
                            Key = "HomeKeyword",
                            Value = "This is keyword of "
                        },
                        new
                        {
                            Key = "HomeDescription",
                            Value = "This is description of "
                        });
                });

            modelBuilder.Entity("Data.Entiti.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                            ConcurrencyStamp = "42c7518e-4a20-4bb4-8b03-75dcf1006f0b",
                            Description = "Administrator role",
                            Name = "admin",
                            NormalizedName = "admin"
                        });
                });

            modelBuilder.Entity("Data.Entiti.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7f7e4eda-7e69-44ca-9105-10615ff26458",
                            Dob = new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "international@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "test",
                            LastName = "test",
                            LockoutEnabled = false,
                            NormalizedEmail = "international@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAED0I2toT9XOgeMpyqvFr49WZXWkBzt2MfwXdq24IxovWqwzFEKbo2ftpxVKGoiUfvw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Data.Entiti.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Data.Entiti.CtrCongNo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CtrDoiTacId")
                        .HasColumnType("int");

                    b.Property<int?>("CtrHopDongId")
                        .HasColumnType("int");

                    b.Property<int?>("CtrKhachHangID")
                        .HasColumnType("int");

                    b.Property<decimal>("DaThanhToan")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DuNo")
                        .HasMaxLength(200)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("IdCongNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("KhauTru")
                        .HasMaxLength(200)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Kyhan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TongNo")
                        .HasMaxLength(200)
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Trangthai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CtrDoiTacId");

                    b.HasIndex("CtrHopDongId");

                    b.HasIndex("CtrKhachHangID");

                    b.ToTable("CongNo", (string)null);
                });

            modelBuilder.Entity("Data.Entiti.CtrDoiTac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("DienThoai")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("IdDoitac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaSoThueDT")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayDangKy")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenDoiTac")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("DoiTac", (string)null);
                });

            modelBuilder.Entity("Data.Entiti.CtrHopDong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CtrDoiTacID")
                        .HasColumnType("int");

                    b.Property<int>("CtrKhachHangID")
                        .HasColumnType("int");

                    b.Property<decimal>("GiaTriGoiDV")
                        .HasMaxLength(200)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("IdHd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("NgayLap")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayNghiemThu")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiPhuTrachHopDong")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("NoiDungHD")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenHopDong")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CtrDoiTacID");

                    b.HasIndex("CtrKhachHangID");

                    b.ToTable("HopDong", (string)null);
                });

            modelBuilder.Entity("Data.Entiti.CtrKhachHang", b =>
                {
                    b.Property<int>("CtrKhachHangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CtrKhachHangID"), 1L, 1);

                    b.Property<string>("Diachi")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Dienthoai")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("MaKH")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MaSothueKH")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayDangKy")
                        .HasColumnType("datetime2");

                    b.Property<string>("Skype")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("CtrKhachHangID");

                    b.ToTable("KhachHang", (string)null);
                });

            modelBuilder.Entity("Data.Entiti.FileHopDong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Caption")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<int>("HopDongId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("HopDongId");

                    b.ToTable("FileHopDong", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                            RoleId = new Guid("8d04dce2-969a-435d-bba4-df3f325983dc")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens", (string)null);
                });

            modelBuilder.Entity("Data.Entiti.CtrCongNo", b =>
                {
                    b.HasOne("Data.Entiti.CtrDoiTac", "CtrDoiTac")
                        .WithMany("ctrCongNos")
                        .HasForeignKey("CtrDoiTacId");

                    b.HasOne("Data.Entiti.CtrHopDong", null)
                        .WithMany("ctrCongNos")
                        .HasForeignKey("CtrHopDongId");

                    b.HasOne("Data.Entiti.CtrKhachHang", null)
                        .WithMany("CtrCongNos")
                        .HasForeignKey("CtrKhachHangID");

                    b.Navigation("CtrDoiTac");
                });

            modelBuilder.Entity("Data.Entiti.CtrHopDong", b =>
                {
                    b.HasOne("Data.Entiti.CtrDoiTac", null)
                        .WithMany("CtrHopDong")
                        .HasForeignKey("CtrDoiTacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entiti.CtrKhachHang", "CtrKhachHang")
                        .WithMany("CtrHopDongs")
                        .HasForeignKey("CtrKhachHangID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CtrKhachHang");
                });

            modelBuilder.Entity("Data.Entiti.FileHopDong", b =>
                {
                    b.HasOne("Data.Entiti.CtrHopDong", "CtrHopDong")
                        .WithMany("FileHopDongs")
                        .HasForeignKey("HopDongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CtrHopDong");
                });

            modelBuilder.Entity("Data.Entiti.CtrDoiTac", b =>
                {
                    b.Navigation("CtrHopDong");

                    b.Navigation("ctrCongNos");
                });

            modelBuilder.Entity("Data.Entiti.CtrHopDong", b =>
                {
                    b.Navigation("FileHopDongs");

                    b.Navigation("ctrCongNos");
                });

            modelBuilder.Entity("Data.Entiti.CtrKhachHang", b =>
                {
                    b.Navigation("CtrCongNos");

                    b.Navigation("CtrHopDongs");
                });
#pragma warning restore 612, 618
        }
    }
}
