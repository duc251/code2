using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class dd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6b16bf87-9696-4305-9e11-0cbcee61f8e3");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8199eb43-70e9-4498-8d69-bd7811ada74d", "AQAAAAEAACcQAAAAEPT9glXhyWRzjxcje/8XJPhWBvLUH6S5gDQt+Y0nyVzfbaDYKEges5ye9v6CM/ir4g==" });

            migrationBuilder.InsertData(
                table: "CongNo",
                columns: new[] { "Id", "CtrDoiTacId", "CtrHopDongId", "CtrKhachHangID", "DaThanhToan", "DoitacId", "DuNo", "GhiChu", "IdCongNo", "KhauTru", "Kyhan", "NgayThanhToan", "TongNo", "Trangthai" },
                values: new object[,]
                {
                    { 1, null, null, null, 132323m, new Guid("00000000-0000-0000-0000-000000000000"), 2323m, "Nợ xấu", "cn1", 323m, new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2332323m, true },
                    { 2, null, null, null, 1342323m, new Guid("00000000-0000-0000-0000-000000000000"), 2323m, "Nợ dài hạn", "cn2", 323m, new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 23323423m, true }
                });

            migrationBuilder.InsertData(
                table: "HopDong",
                columns: new[] { "Id", "CtrCongNoID", "CtrDoiTacID", "CtrKhachHangID", "GiaTriGoiDV", "IdHd", "KhachangId", "NgayLap", "NgayNghiemThu", "NguoiPhuTrachHopDong", "NoiDungHD", "TenHopDong", "TrangThai" },
                values: new object[,]
                {
                    { 1, 0, 0, 0, 5000000000m, "HD2", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chị Đức", "xây dựng chủ trì cơ cấu doanh nghiệp", "Hợp Đồng xây dựng", true },
                    { 2, 0, 0, 0, 5000000000m, "HD2", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chị Đức", "xây dựng chủ trì cơ cấu doanh nghiệp", "Hợp Đồng xây dựng", true }
                });

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "CtrKhachHangID", "Diachi", "Dienthoai", "Email", "MaKH", "MaSothueKH", "NgayCapNhat", "NgayDangKy", "Skype", "TenKhachHang", "TrangThai" },
                values: new object[,]
                {
                    { 1, "Xuân Khanh,Sơn Tây,Hà Nội", 1237830068, "bossonekill@gmail.com", "Kh1", 112545644, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "manh123", "Lê Minh Sơn", true },
                    { 2, "Xuân Khanh,Sơn Tây,Hà Nội", 1237830068, "trumbossonekill@gmail.com", "Kh2", 112545644, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhphuong", "Chu Văn Phương", true }
                });

            migrationBuilder.InsertData(
                table: "FileHopDong",
                columns: new[] { "Id", "Caption", "DateCreate", "FilePath", "FileSize", "HopDongId", "IsDefault" },
                values: new object[] { 1, "xây dựng chủ trì cơ cấu doanh nghiệp", new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hợp Đồng xây dựng", 0L, 1, true });

            migrationBuilder.InsertData(
                table: "FileHopDong",
                columns: new[] { "Id", "Caption", "DateCreate", "FilePath", "FileSize", "HopDongId", "IsDefault" },
                values: new object[] { 2, "xây dựng chủ trì cơ cấu doanh nghiệp", new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hợp Đồng xây dựng", 0L, 1, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CongNo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CongNo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FileHopDong",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FileHopDong",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HopDong",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KhachHang",
                keyColumn: "CtrKhachHangID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KhachHang",
                keyColumn: "CtrKhachHangID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HopDong",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "5be4729d-b464-484d-8840-7577be8e2993");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fbc0551e-4f6a-460b-bdfd-54c5249f7322", "AQAAAAEAACcQAAAAEEPtcgbzTzAru/69DCt3nKYmwrucrugjfVnRxCBjxJeKtDqwzLkNbyEZkCVRYS8U4g==" });
        }
    }
}
