using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "168ac687-a2ad-4a71-8287-698591205e9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "834c675d-09cb-4451-ae97-5565bb319016");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7d9ef383-aa44-4bce-ace3-c5825288a02a", "c8ff3bfd-c65e-439d-bebd-7e5f2d282982", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d8b1b75-bc44-4147-8a92-0ea00a613b05", "1e592d19-0518-4985-9fa5-8b2c7aa2212a", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d8b1b75-bc44-4147-8a92-0ea00a613b05");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d9ef383-aa44-4bce-ace3-c5825288a02a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "834c675d-09cb-4451-ae97-5565bb319016", "3b0e4264-52fd-4012-b14f-652d6c1bc24b", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "168ac687-a2ad-4a71-8287-698591205e9c", "6439320e-b297-4778-882a-756f5c5a2521", "Customer", "CUSTOMER" });
        }
    }
}
