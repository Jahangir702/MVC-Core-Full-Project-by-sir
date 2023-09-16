using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace R54_M10_Class_01_Work_01.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "money", nullable: false),
                    SellUnit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductInventories",
                columns: table => new
                {
                    ProductInventoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInventories", x => x.ProductInventoryId);
                    table.ForeignKey(
                        name: "FK_ProductInventories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Picture", "SellUnit", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "P01", "1.jpg", 1, 950.00m },
                    { 2, "P02", "2.jpg", 1, 1900.00m },
                    { 3, "P03", "3.jpg", 1, 2850.00m },
                    { 4, "P04", "4.jpg", 1, 3800.00m },
                    { 5, "P05", "5.jpg", 1, 4750.00m },
                    { 6, "P06", "6.jpg", 1, 5700.00m },
                    { 7, "P07", "7.jpg", 1, 6650.00m }
                });

            migrationBuilder.InsertData(
                table: "ProductInventories",
                columns: new[] { "ProductInventoryId", "Date", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 23, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8476), 1, 50 },
                    { 2, new DateTime(2023, 7, 31, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8524), 2, 100 },
                    { 3, new DateTime(2023, 7, 8, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8538), 3, 150 },
                    { 4, new DateTime(2023, 6, 15, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8551), 4, 200 },
                    { 5, new DateTime(2023, 5, 23, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8565), 5, 250 },
                    { 6, new DateTime(2023, 4, 30, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8579), 6, 300 },
                    { 7, new DateTime(2023, 4, 7, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8593), 7, 350 },
                    { 8, new DateTime(2023, 3, 15, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8606), 1, 400 },
                    { 9, new DateTime(2023, 2, 20, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8622), 2, 450 },
                    { 10, new DateTime(2023, 1, 28, 12, 41, 14, 760, DateTimeKind.Local).AddTicks(8638), 3, 500 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInventories_ProductId",
                table: "ProductInventories",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductInventories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
