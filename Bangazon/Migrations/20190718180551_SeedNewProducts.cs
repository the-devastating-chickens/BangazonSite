using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class SeedNewProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d53febbd-584c-4b36-8f3a-85fd7e5138f5", "AQAAAAEAACcQAAAAEL58mH8dyss2g1Agt1xw85Hmx2MBJ7MDXR63jYQgop0RlkViGjmaFIf/Oh13VOFgRg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "149c98cb-8014-48b4-9cb8-2e5cec5a510d", "AQAAAAEAACcQAAAAEK8RF9AqaVvkdtoQ5Ku2PkfTDzKRiR2CWnGAmxTe5mrJqJsrLEvf/Ub4OZbnZSe7dg==" });
        }
    }
}
