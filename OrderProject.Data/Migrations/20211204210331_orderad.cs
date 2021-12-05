using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderProject.Data.Migrations
{
    public partial class orderad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedOn", "Status" },
                values: new object[] { new DateTime(2021, 10, 16, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5920), 30 });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Order",
                columns: new[] { "Id", "BrandId", "CreatedOn", "CustomerName", "Price", "Status", "StoreName" },
                values: new object[,]
                {
                    { 4, 2, new DateTime(2021, 11, 25, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5930), "Feyza Güler", 90m, 40, "Shopi" },
                    { 5, 8, new DateTime(2021, 11, 30, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5934), "Enise Güler", 70m, 10, "Shopi" },
                    { 6, 7, new DateTime(2021, 11, 26, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5943), "Adem Güler", 50m, 20, "Shopi" },
                    { 7, 6, new DateTime(2021, 10, 1, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5947), "Şimşek Güler", 220m, 10, "Shopi" },
                    { 8, 5, new DateTime(2021, 9, 8, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5952), "Abdullah Güler", 87m, 10, "Shopi" },
                    { 9, 21, new DateTime(2021, 11, 24, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5957), "Nurullah Güler", 65m, 10, "Shopi" },
                    { 10, 14, new DateTime(2021, 11, 28, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5961), "Enes Güler", 65m, 10, "Shopi" },
                    { 11, 2, new DateTime(2021, 11, 25, 0, 3, 31, 71, DateTimeKind.Local).AddTicks(5965), "Emel Güler", 87m, 10, "Shopi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 5, 0, 2, 4, 465, DateTimeKind.Local).AddTicks(2286));

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
                columns: new[] { "CreatedOn", "Status" },
                values: new object[] { new DateTime(2021, 12, 5, 0, 2, 4, 467, DateTimeKind.Local).AddTicks(2787), 10 });
        }
    }
}
