using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class NewProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e971e44a-66cf-4cd3-afc0-3ec5795edb35", "AQAAAAEAACcQAAAAEM8GbBWr9iAugADq7E9QEzM6rL0VnkAr3kpX4W82uP8xbpteK53oNFLUTDLi/a9umQ==" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Active", "City", "Description", "ImagePath", "Price", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[] { 6, true, null, "It blends", null, 22.690000000000001, 2, 32, "Blender", "00000000-ffff-ffff-ffff-ffffffffffff" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1db8b16-9055-484a-9770-cac8dd7efc75", "AQAAAAEAACcQAAAAEDu5ROwXHE71x2mKmA4L5LaCWiVzUYkXpHu8sc5jQKYVWD7bCOCv8AutquUZwOxyog==" });
        }
    }
}
