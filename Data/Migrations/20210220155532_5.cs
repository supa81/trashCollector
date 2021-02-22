using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd106bb5-3a9c-429b-94fe-bc3630689c91", "5cb464b2-6c71-43ae-9382-bbfab1f61cd4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bbba25ec-8cf5-4786-8278-c94bb845b1d0", "5c28233b-d0f4-4b5c-8655-c891f2f94ea5", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b1007aa-b05c-4499-a79a-cc5cac5ff5ae", "4b5f7330-4c2d-472c-97b9-996757d080a4", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b1007aa-b05c-4499-a79a-cc5cac5ff5ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbba25ec-8cf5-4786-8278-c94bb845b1d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd106bb5-3a9c-429b-94fe-bc3630689c91");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customer");

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
    }
}
