using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class NewProductData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5db0b14-f5bd-46ac-9a25-37efa4817fd9", "AQAAAAEAACcQAAAAEKl6ZBA/jUNwirtQom7mlaKm7AEvSwu29aDPVOfDRfMzdgERvsaxPdhqqdlDOVQ9kg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d53febbd-584c-4b36-8f3a-85fd7e5138f5", "AQAAAAEAACcQAAAAEL58mH8dyss2g1Agt1xw85Hmx2MBJ7MDXR63jYQgop0RlkViGjmaFIf/Oh13VOFgRg==" });
        }
    }
}
