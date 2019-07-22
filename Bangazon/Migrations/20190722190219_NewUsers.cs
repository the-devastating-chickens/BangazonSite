using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class NewUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8fa28b30-30b2-4be6-952d-d305e44de8bb", "AQAAAAEAACcQAAAAEON1dUP2mcVVc9JA40tplzsAZwwwL/7KaGmzAjMf2tQkQxLP5a8u6u+n8TkIWxhN2A==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00000330-ffff-ffff-ffff-ffffffffffff", 0, "e6c92d3f-95b6-42c6-a430-f01fd6392a04", "rose@rose.com", true, "Rose", "Wisotzky", false, null, "ROSE@ROSE.COM", "ROSE@ROSE.COM", null, null, false, "7f434300-a4d9-48e9-9ebb-8803db794577", "21 Lover's Lane", false, "rose@rose.com" },
                    { "02200330-ffff-ffff-ffff-ffffffffffff", 0, "d2902e8f-0881-493b-9522-9b5290af6528", "chris@chris.com", true, "Chris", "Morgan", false, null, "CHRIS@CHRIS.COM", "CHRIS@CHRIS.COM", null, null, false, "7f422300-a4d9-48e9-9ebb-8803db794577", "22 Lover's Lane", false, "chris@chris.com" },
                    { "45000330-ffff-ffff-ffff-ffffffffffff", 0, "730c95f2-9232-4fb0-99dc-b4b62f47c83a", "anne@anne.com", true, "Anne Rae", "Vick", false, null, "ANNE@ANNE.COM", "ANNE@ANNE.COM", null, null, false, "7f004300-a4d9-48e9-9ebb-8803db794577", "19 Lover's Lane", false, "anne@anne.com" },
                    { "45670330-ffff-ffff-ffff-ffffffffffff", 0, "899fd2db-9f04-481f-894c-01b6bcc5b49a", "billy@billy.com", true, "Billy", "M", false, null, "BILLY@BILLY.COM", "BILLY@BILLY.COM", null, null, false, "7f004300-a4d9-48e9-9ebb-8803db794577", "33 Lover's Lane", false, "billy@billy.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000330-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02200330-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45000330-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e91a9f15-2ea2-4825-830b-c8887bde7a59", "AQAAAAEAACcQAAAAEB6SBptLJhbzUCBeto589kSNiz3dHJqcsCfe3x0ZHU0rYyrzG2j33bqpoi8DY+cJbQ==" });
        }
    }
}
