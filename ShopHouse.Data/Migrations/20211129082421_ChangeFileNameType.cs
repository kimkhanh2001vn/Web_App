using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopHouse.Data.Migrations
{
    public partial class ChangeFileNameType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9dc58d1f-d59b-4309-b6ca-430cb5967466");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb126847-5051-4553-b68a-b25efbdee962", "AQAAAAEAACcQAAAAEIVirJlsxOHYAxqgKxHtAaNnYWcGBCxeBvj0eWUQvRY9BycFx0icMIuDTo7puiHWgA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 11, 29, 15, 24, 21, 176, DateTimeKind.Local).AddTicks(8982));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6de1d85b-850d-4f92-95f8-6fa6acf96b24");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a30bf52-9635-4575-ba19-d030962441ab", "AQAAAAEAACcQAAAAEGIqyaEMjd/Brz4t8OZ4mrihJ7vEi3iD/oV9ynXHVbzm3b3LquOBCxUO3XEJ7SOMNw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 11, 29, 10, 54, 55, 697, DateTimeKind.Local).AddTicks(6453));
        }
    }
}
