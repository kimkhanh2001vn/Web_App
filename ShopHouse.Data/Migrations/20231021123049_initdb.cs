using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopHouse.Data.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "252cc1d7-43e8-4fb7-a2e7-f40b80a9ee5b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ced6b4b-17dd-4783-ae76-7df4872112b9", "AQAAAAEAACcQAAAAEKP7G27xjFA5AeHIOUul48Kyt4dzEF1E5skX5lkdFTqNPdFV8nnXgCnAPYgUBnjxpQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 21, 19, 30, 48, 517, DateTimeKind.Local).AddTicks(2549));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c14b25bc-89d5-4e46-b442-904219579181");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2a50f01-f4af-4c96-b4aa-68136babe463", "AQAAAAEAACcQAAAAENWjm9oujqsrA29sH9CW/E5YzGaUGp7eyH1i3VnLGRKNrDEyyUysiJwWqHgK4hlcdw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 9, 6, 15, 7, 50, 645, DateTimeKind.Local).AddTicks(7597));
        }
    }
}
