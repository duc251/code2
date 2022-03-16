using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CongNo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DoiTac",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DoiTac",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9e7447d6-04da-4055-aa4b-4bad1b003053");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bdb3c347-5d99-4130-b0fd-5198ce5c3c4a", "AQAAAAEAACcQAAAAEMo97YSXUtJY94JgukpOFdP6aLiurzTLEju9hD32Aaqy/2Q8KB8KtiEkLH4ud7YpIQ==" });

            migrationBuilder.InsertData(
                table: "CongNo",
                columns: new[] { "Id", "CtrDoiTacId", "CtrHopDongId", "CtrKhachHangID", "DaThanhToan", "DoitacId", "DuNo", "GhiChu", "IdCongNo", "KhauTru", "Kyhan", "NgayThanhToan", "TongNo", "Trangthai" },
                values: new object[] { 10, null, null, null, 132323m, new Guid("00000000-0000-0000-0000-000000000000"), 2323m, "Nợ xấu", "cn1", 323m, new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2332323m, true });

            migrationBuilder.InsertData(
                table: "DoiTac",
                columns: new[] { "Id", "DiaChi", "DienThoai", "IdDoitac", "MaSoThueDT", "NgayCapNhat", "NgayDangKy", "TenDoiTac", "TrangThai" },
                values: new object[,]
                {
                    { 7, "phạm văn mạnh", 1555555, null, 777, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phạm văn mạnh", false },
                    { 9, "phạm văn mạnh", 1555555, null, 777, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phạm văn mạnh", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CongNo",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DoiTac",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DoiTac",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "dc273a67-49f2-4086-a298-dd276b9a7344");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d56999e0-f9c9-48df-a50e-d009ee516b8a", "AQAAAAEAACcQAAAAENwnEa5009/9upn59WYQoDETY62yOq7QdJQ5UjR0jOC1QMLLfJaJZa85VFBkSu+L6Q==" });

            migrationBuilder.InsertData(
                table: "CongNo",
                columns: new[] { "Id", "CtrDoiTacId", "CtrHopDongId", "CtrKhachHangID", "DaThanhToan", "DoitacId", "DuNo", "GhiChu", "IdCongNo", "KhauTru", "Kyhan", "NgayThanhToan", "TongNo", "Trangthai" },
                values: new object[] { 1, null, null, null, 132323m, new Guid("00000000-0000-0000-0000-000000000000"), 2323m, "Nợ xấu", "cn1", 323m, new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2332323m, true });

            migrationBuilder.InsertData(
                table: "DoiTac",
                columns: new[] { "Id", "DiaChi", "DienThoai", "IdDoitac", "MaSoThueDT", "NgayCapNhat", "NgayDangKy", "TenDoiTac", "TrangThai" },
                values: new object[,]
                {
                    { 1, "phạm văn mạnh", 1555555, null, 777, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phạm văn mạnh", false },
                    { 2, "phạm văn mạnh", 1555555, null, 777, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phạm văn mạnh", false }
                });
        }
    }
}
