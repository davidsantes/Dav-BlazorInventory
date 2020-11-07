using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" },
                    { "PRF", "Perfumería" },
                    { "SLD", "Salud" },
                    { "VDJ", "Video Juegos" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "3b99798c-689d-424f-b7b2-920f00fbb93c", "932 Pallet Street, La Grange, NY 12540", "Main Warehouse" },
                    { "34d3da92-07dd-48d9-b60b-99138f586db0", "4447 Dane Street, Yakima, WA 98908", "Second Warehouse" },
                    { "d7b51d26-e221-4b47-9783-a813a6c3d1b7", "3003 Arrowood Drive, Jacksonville, FL 32257", "Third Warehouse" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASP");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "HGR");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "PRF");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "SLD");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "VDJ");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "34d3da92-07dd-48d9-b60b-99138f586db0");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "3b99798c-689d-424f-b7b2-920f00fbb93c");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "d7b51d26-e221-4b47-9783-a813a6c3d1b7");
        }
    }
}
