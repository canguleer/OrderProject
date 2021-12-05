using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderProject.Data.Migrations
{
    public partial class orderadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2021, 12, 5, 0, 2, 4, 465, DateTimeKind.Local).AddTicks(2286), 17m });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 0, 2, 4, 467, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 0, 2, 4, 467, DateTimeKind.Local).AddTicks(2787));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Price" },
                values: new object[] { new DateTime(2021, 12, 4, 21, 54, 35, 51, DateTimeKind.Local).AddTicks(4412), 18m });

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
    }
}
