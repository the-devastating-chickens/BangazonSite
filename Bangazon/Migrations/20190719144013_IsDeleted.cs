using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class IsDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PaymentType",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "940a022c-17ec-433e-a7fd-afe668f8b50b", "AQAAAAEAACcQAAAAENO4hWemVqjET+lDxBVmWj5i38XIOYfCNJFJGhTQSu8MYgpYUi1M4rPV9J5gPzBccg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PaymentType");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cabb14bd-8b3c-4723-a9e7-f58c0a710003", "AQAAAAEAACcQAAAAEI6v/RaTKREgSjW1JbS4usOclIC64HPEkgjRYTXV6jOTwZIxghloQDR83lw5NTGEXA==" });
        }
    }
}
