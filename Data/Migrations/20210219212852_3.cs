using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f2c9e1-56ca-42ed-8de4-bbffc106ba4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32183bf2-2ce9-47f8-a31e-70fec8442718");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a86f0784-f52f-4a43-8157-174a5134ab66");

            migrationBuilder.AlterColumn<bool>(
                name: "ExtraOneTimePickUp",
                table: "Employee",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "CompletedPickUp",
                table: "Employee",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "ExtraOneTimePickUp",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CompletedPickUp",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "ExtraOneTimePickUp",
                table: "Employee",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "ExtraOneTimePickUp",
                table: "Customer",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20f2c9e1-56ca-42ed-8de4-bbffc106ba4a", "2a90dcd8-5397-465d-ab81-bec63f019c53", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32183bf2-2ce9-47f8-a31e-70fec8442718", "60a3e537-8583-4c4a-8756-d3a1b5a7c792", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a86f0784-f52f-4a43-8157-174a5134ab66", "6b97201b-38fc-458e-a0c4-63d16ee3fc00", "Customer", "CUSTOMER" });
        }
    }
}
