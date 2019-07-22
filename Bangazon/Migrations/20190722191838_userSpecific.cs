using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class userSpecific : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "42812836-2c81-46ff-8db0-75ce94b068b1", "AQAAAAEAACcQAAAAEJ9TDtHfK2/aTXgITjO2Foi6UU/oxMkZpe8MfE8r6sBZYLSpLMbHu1pfVCDCP+8B1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03bad54b-fc09-46e8-9a8d-ca8e93f51ace", "AQAAAAEAACcQAAAAEEMqJ36YFpMnx3DqBt2tovw9MdWdtcdP+9Rszg8SvdS89o9/C4GlgKdnTyx1bk898A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02200330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "702c5ddf-1ede-4c29-b64e-275d1a4cf364", "AQAAAAEAACcQAAAAEF7BEi9PmRujwEAH0wyZfmyGjSXYYTez4rX21ulUogpxM2n453G7y5eLm3P3+Wd0Hg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45000330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "106e643b-fe9a-49ca-ad3d-e9c55b8ad3b6", "AQAAAAEAACcQAAAAECJdTmLbk8QvRnUDnmet3w/sgqG2PcLRvfReTNbxq05wbgNik/Nxg/DNVJvvL9EL4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45670330-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f52e193e-4d88-48c9-8557-3324f7b0ee56", "AQAAAAEAACcQAAAAEGttm2+nMXHPiwI7+3Uk2dTsB/sHiyBNykEJaR9LUjd4/78l6KXG/ErfMiAKAMHoIQ==" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "UserId",
                value: "45670330-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "UserId",
                value: "00000330-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "UserId",
                value: "45670330-ffff-ffff-ffff-ffffffffffff");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "UserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "UserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "UserId",
                value: "02200330-ffff-ffff-ffff-ffffffffffff");
        }
    }
}
