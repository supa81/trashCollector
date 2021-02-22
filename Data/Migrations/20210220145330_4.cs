using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02694f45-1568-4c4e-a388-5982fedf3fd5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d5b56eb-4dfa-4641-8ec8-5b9d0ce97ded");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3d43a79-b5ab-47fe-a007-b5e422b88852");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b22e2d20-16ab-4227-a181-bfed8f5eb603", "dde6629d-a89b-4bf6-a4e8-c6d0d5697457", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b0b04f0a-5b1a-4701-9c00-7d2930ae87f8", "4b17b188-2b17-4d1c-8b93-9c49823f2853", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e5db443-d0c9-4bc4-8aca-37f4ec94f279", "cf75e0cb-6ede-4927-a795-a2b761b4e89f", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e5db443-d0c9-4bc4-8aca-37f4ec94f279");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0b04f0a-5b1a-4701-9c00-7d2930ae87f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b22e2d20-16ab-4227-a181-bfed8f5eb603");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "02694f45-1568-4c4e-a388-5982fedf3fd5", "f7476e91-77fa-44b9-a7b4-19fecd80eb58", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e3d43a79-b5ab-47fe-a007-b5e422b88852", "a5bd4076-1cc5-4cd1-b3b9-df665d3ec1be", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d5b56eb-4dfa-4641-8ec8-5b9d0ce97ded", "4e0c971a-0bf8-4ca7-a8f4-69f6433dc67c", "Customer", "CUSTOMER" });
        }
    }
}
