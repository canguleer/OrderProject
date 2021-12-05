using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderProject.Data.Migrations
{
    public partial class Db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 9, 26, 50, 552, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 25, 9, 26, 50, 554, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 10, 16, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 25, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 30, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 26, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 10, 1, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 9, 8, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 24, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 28, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 25, 9, 26, 50, 555, DateTimeKind.Local).AddTicks(108));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 0, 3, 31, 69, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 25, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 10, 16, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 25, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 30, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 26, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 10, 1, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 9, 8, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 24, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 28, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 25, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5965));
        }
    }
}
