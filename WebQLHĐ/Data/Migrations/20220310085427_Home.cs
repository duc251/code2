using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Home : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "4d550938-c733-4298-a935-b6dac8a4ef3b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "50e9784d-989a-4fbd-9bd5-30dc35599957", "AQAAAAEAACcQAAAAEOL8bL3hqpJ+ydNsVHEK9sFwGJ/UI6Myb/ZqjGvQRZETzaw2P+yfRLcY5ulhDv829Q==" });
        }
    }
}
