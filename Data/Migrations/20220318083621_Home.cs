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
                value: "78884255-8cac-4a2f-a93a-26c980de7cde");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16ce1c53-7471-4fdd-8a23-e7044d74d8e8", "AQAAAAEAACcQAAAAECf/xNf8OY9zD4L7IahxaDQbBEiqpvn6jOV1NvJpHX1rXNFyWvQ71QHtB9gr8oDsHA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "42c7518e-4a20-4bb4-8b03-75dcf1006f0b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f7e4eda-7e69-44ca-9105-10615ff26458", "AQAAAAEAACcQAAAAED0I2toT9XOgeMpyqvFr49WZXWkBzt2MfwXdq24IxovWqwzFEKbo2ftpxVKGoiUfvw==" });
        }
    }
}
