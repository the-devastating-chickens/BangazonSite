using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class realNewUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cec26e2b-7747-4717-8fa1-d3bdcaa481b9", "AQAAAAEAACcQAAAAEOLk3E+AvtE94QbFYvC0zAS1JNOMl9xxB8aSu7PdLd76+LC7RbVpXRHlXxuSrOT4vw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cdb7d439-30b9-40f1-8639-d4fb14e44841", "AQAAAAEAACcQAAAAENTMKU7KlqzSfkTiLCmlPr66YOd34ageJpgfPhK0Pl6wQs3qhZlKHIHi5pUpKlbG6Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02200330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9034f807-1ccd-46af-8da3-c55e43576348", "AQAAAAEAACcQAAAAEMO+TW1UYJl52jKvAKPuDUTbDGOYZDxrcET8OonTHzyhNgNRqp9SPYW4warJM1ltlA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45000330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e776ca6-caae-4b64-9793-fd1a8330b2b4", "AQAAAAEAACcQAAAAEJo8lF+yGaoZLkxMXAk4FgyVpe6Q/2Q9iRKSxkd9FWUjogbe1syP7Xcnbxx7kxke7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f5edda26-74cf-4593-b4d9-6a7494d5e6a8", "AQAAAAEAACcQAAAAEM2e7AzhkthFbA/9yIoi54z2+fEgHHmiyrpqIqDwElJeXtl9/Ht5V44fBCFX2PlrqA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8fa28b30-30b2-4be6-952d-d305e44de8bb", "AQAAAAEAACcQAAAAEON1dUP2mcVVc9JA40tplzsAZwwwL/7KaGmzAjMf2tQkQxLP5a8u6u+n8TkIWxhN2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6c92d3f-95b6-42c6-a430-f01fd6392a04", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02200330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d2902e8f-0881-493b-9522-9b5290af6528", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45000330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "730c95f2-9232-4fb0-99dc-b4b62f47c83a", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "899fd2db-9f04-481f-894c-01b6bcc5b49a", null });
        }
    }
}
