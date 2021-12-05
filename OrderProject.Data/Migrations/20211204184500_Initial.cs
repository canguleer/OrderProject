using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderProject.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Order",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StoreName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Order",
                columns: new[] { "Id", "BrandId", "CreatedOn", "CustomerName", "Price", "Status", "StoreName" },
                values: new object[] { 1, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Can Güler", 18m, 10, "Shopi" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Order",
                columns: new[] { "Id", "BrandId", "CreatedOn", "CustomerName", "Price", "Status", "StoreName" },
                values: new object[] { 2, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mehmet Güler", 55m, 50, "Shopi" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Order",
                columns: new[] { "Id", "BrandId", "CreatedOn", "CustomerName", "Price", "Status", "StoreName" },
                values: new object[] { 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmet Güler", 60m, 10, "Shopi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order",
                schema: "dbo");
        }
    }
}
