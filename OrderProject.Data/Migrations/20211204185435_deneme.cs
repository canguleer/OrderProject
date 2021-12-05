using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderProject.Data.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 21, 54, 35, 51, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 21, 54, 35, 53, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 4, 21, 54, 35, 53, DateTimeKind.Local).AddTicks(5306));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
