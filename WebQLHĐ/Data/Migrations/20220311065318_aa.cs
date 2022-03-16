using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "HopDong",
                keyColumn: "Id",
                keyValue: 1,
                column: "CtrDoiTacID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "HopDong",
                keyColumn: "Id",
                keyValue: 2,
                column: "CtrDoiTacID",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "HopDong",
                keyColumn: "Id",
                keyValue: 1,
                column: "CtrDoiTacID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "HopDong",
                keyColumn: "Id",
                keyValue: 2,
                column: "CtrDoiTacID",
                value: 0);
        }
    }
}
