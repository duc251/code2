using Data.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QLHĐSolotion.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
              new AppConfig() { Key = "HomeTitle", Value = "This is home page of  " },
              new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of  " },
              new AppConfig() { Key = "HomeDescription", Value = "This is description of  " }
              );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = false });


            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });


            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "international@gmail.com",
                NormalizedEmail = "international@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "tesr",
                LastName = "tesr",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<CtrDoiTac>().HasData(
              new CtrDoiTac()
              {
                  Id = 1,
                  
                  TenDoiTac = "phạm văn mạnh",
                  DiaChi = "phạm văn mạnh", 
                  MaSoThueDT = 777,
                  DienThoai = 1555555,
                


              },
               new CtrDoiTac()
               {
                   Id = 2,
                   
                   TenDoiTac = "phạm văn mạnh",
                   DiaChi = "phạm văn mạnh",
                   MaSoThueDT = 777,
                   DienThoai = 1555555,
               

               });

         //   modelBuilder.Entity<CtrCongNo>().HasData(
         //  new CtrCongNo()
         //  {

         //      Id = 1,
         //      IdCongNo = "cn1",

         //      TongNo = 2332323,

         //      DaThanhToan = 132323,

         //      NgayThanhToan = new DateTime(2020, 01, 31),

         //      DuNo = 2323,

         //      KhauTru = 323,

         //      Kyhan = new DateTime(2022, 01, 31),

         //      GhiChu = "Nợ xấu",

         //      Trangthai = true,




         //  },
         //   new CtrCongNo()
         //   {
         //       Id = 2,
         //       IdCongNo = "cn2",

         //       TongNo = 23323423,

         //       DaThanhToan = 1342323,

         //       NgayThanhToan = new DateTime(2020, 01, 31),

         //       DuNo = 2323,

         //       KhauTru = 323,

         //       Kyhan = new DateTime(2022, 01, 31),

         //       GhiChu = "Nợ dài hạn",

         //       Trangthai = true,

         //   });




         //   modelBuilder.Entity<CtrKhachHang>().HasData(
         //  new CtrKhachHang
         //  {
         //      CtrKhachHangID = 1,

         //      MaKH = "Kh1",

         //      TenKhachHang ="Lê Minh Sơn",

         //      MaSothueKH = 112545644,

         //      Diachi = "Xuân Khanh,Sơn Tây,Hà Nội",

         //      Dienthoai = 01237830068,

         //      Skype = "manh123",

         //      Email = "bossonekill@gmail.com",

         //      NgayDangKy = new DateTime(2022, 05, 11),

         //      NgayCapNhat = new DateTime(2022, 06, 22),

         //      TrangThai = true,




         //  },
         //   new CtrKhachHang()
         //   {
         //       CtrKhachHangID = 2,
         //       MaKH = "Kh2",

         //       TenKhachHang = "Chu Văn Phương",

         //       MaSothueKH = 112545644,

         //       Diachi = "Xuân Khanh,Sơn Tây,Hà Nội",

         //       Dienthoai = 01237830068,

         //       Skype = "thanhphuong",

         //       Email = "trumbossonekill@gmail.com",

         //       NgayDangKy = new DateTime(2022, 05, 11),

         //       NgayCapNhat = new DateTime(2022, 06, 22),

         //       TrangThai = true,

         //   });
         //   modelBuilder.Entity<CtrHopDong>().HasData(
         //new CtrHopDong
         //{

         //    Id =1,
         //    IdHd = "HD2",

         //    TenHopDong = "Hợp Đồng xây dựng",

         //    NoiDungHD = "xây dựng chủ trì cơ cấu doanh nghiệp",

         //    NgayLap = new DateTime(2022, 06, 22),

         //    NgayNghiemThu = new DateTime(2022, 06, 22),

         //    NguoiPhuTrachHopDong = "Chị Đức",

         //    GiaTriGoiDV = 5000000000,

         //  CtrDoiTacID=1,
         //    TrangThai = true,




         //},
         // new CtrHopDong()
         // {

         //     Id = 2,
         //     IdHd = "HD2",

         //     TenHopDong = "Hợp Đồng xây dựng",

         //     NoiDungHD = "xây dựng chủ trì cơ cấu doanh nghiệp",

         //     NgayLap = new DateTime(2022, 06, 22),

         //     NgayNghiemThu = new DateTime(2022, 06, 22),

         //     NguoiPhuTrachHopDong = "Chị Đức",

         //     GiaTriGoiDV = 5000000000,
         //     CtrDoiTacID = 2,
         //     TrangThai = true,


         // });
         //   modelBuilder.Entity<FileHopDong>().HasData(
         //new FileHopDong
         //{
         //    Id=1,

         //    HopDongId = 1,

         //    FilePath = "Hợp Đồng xây dựng",

         //    Caption = "xây dựng chủ trì cơ cấu doanh nghiệp",

         //    IsDefault = true,

         //    DateCreate = new DateTime(2022, 06, 22),

             




         //},
         // new FileHopDong()
         // {


         //     Id=2,
         //     HopDongId = 1,

         //     FilePath = "Hợp Đồng xây dựng",

         //     Caption = "xây dựng chủ trì cơ cấu doanh nghiệp",

         //     IsDefault = true,

         //     DateCreate = new DateTime(2022, 06, 22),


         // });
        }
    }
}
