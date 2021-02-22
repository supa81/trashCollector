using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "StartDayOfService",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "EndDayOfService",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "283b86ff-e246-49e8-a1c5-655125f1ce19", "597dbb3c-f4de-41b5-a41b-8476e53e5eb5", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ae418fea-d505-4ccd-a5f4-b71f9a1d0325", "ff07bf41-4d55-42df-adf9-74629dc4ad9c", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "283b86ff-e246-49e8-a1c5-655125f1ce19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae418fea-d505-4ccd-a5f4-b71f9a1d0325");

            migrationBuilder.AlterColumn<int>(
                name: "StartDayOfService",
                table: "Customer",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EndDayOfService",
                table: "Customer",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
