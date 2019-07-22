using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class UserIdProductData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e5c89d9d-60dd-4864-b866-238dd423d6e5", "AQAAAAEAACcQAAAAEEniRF2nac6EsWnNuhywXjyGWP3eqJniXZt/DWKZUAZhyP3Hy0JtoUVFNRiqK707vQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "66444ee5-6886-4ebf-a48e-f342ff44ff79", "AQAAAAEAACcQAAAAEB0hE+5hnFofCwVU7NXR8EtOlOYs/BjJJDXBTAjARN6+hsFZS1GTOAFB4FY+pIIcEA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02200330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "276bb599-3e4e-41af-83e1-970284c8cf59", "AQAAAAEAACcQAAAAEP5tmVMPiWUC3vQW5HR4cJJdM8Gi8BCbshztMq/SK2RTqy7HDzVnBCcM5IrdbemUog==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45000330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31b91774-18dd-4619-aff2-21268a9a68f0", "AQAAAAEAACcQAAAAEHIYLEHvPvyT0NL6gz0JuhbI1OZkbE+U06k4inzu8jGVQ+LNWWj8prQcYXT4m27Ynw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "000f23ce-30aa-44fd-82cf-f38cb927ffc4", "AQAAAAEAACcQAAAAEAvQ3LcB4nDu0cdyNzjQRkCyIUArIarIN4Zs/48z9J+s6DLZqVD1nThqrqoS7xG4rg==" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "UserId",
                value: "00000330-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "UserId",
                value: "02200330-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "UserId",
                value: "45000330-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "UserId",
                value: "02200330-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "UserId",
                value: "00000330-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "UserId",
                value: "45000330-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "UserId",
                value: "00000330-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "UserId",
                value: "02200330-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "UserId",
                value: "45000330-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "UserId",
                value: "02200330-ffff-ffff-ffff-ffffffffffff");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "UserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "UserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "UserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "UserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "UserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "UserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "UserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "UserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "UserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "UserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");
        }
    }
}
