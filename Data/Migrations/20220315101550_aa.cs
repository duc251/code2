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
                table: "AppConfig",
                keyColumn: "Key",
                keyValue: "HomeDescription",
                column: "Value",
                value: "This is description of ");

            migrationBuilder.UpdateData(
                table: "AppConfig",
                keyColumn: "Key",
                keyValue: "HomeKeyword",
                column: "Value",
                value: "This is keyword of ");

            migrationBuilder.UpdateData(
                table: "AppConfig",
                keyColumn: "Key",
                keyValue: "HomeTitle",
                column: "Value",
                value: "This is home page of ");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "27eebed0-ec9a-469e-9cc9-9830b1576264");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9664b21-3bbe-4621-970e-b3c60387ae45", "AQAAAAEAACcQAAAAEE8Iu0ahF0mGaAtNr+1X6wUQqWBkGwLmcQxUR8hwcF3gJQm3CybjwX7DAZCPbKZwHw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppConfig",
                keyColumn: "Key",
                keyValue: "HomeDescription",
                column: "Value",
                value: "This is description of eShopSolution");

            migrationBuilder.UpdateData(
                table: "AppConfig",
                keyColumn: "Key",
                keyValue: "HomeKeyword",
                column: "Value",
                value: "This is keyword of eShopSolution");

            migrationBuilder.UpdateData(
                table: "AppConfig",
                keyColumn: "Key",
                keyValue: "HomeTitle",
                column: "Value",
                value: "This is home page of eShopSolution");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "067f1ca7-4f64-4416-8438-d93be6c4fb85");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "703f1698-a55a-4a86-adf5-45320d7a1059", "AQAAAAEAACcQAAAAEGJ0MlR7DpGORFo+ypwCudzI2OgOuG6SpfETK5nHm4eh8ImoH9byuXaVDDG6tamMrg==" });
        }
    }
}
