using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ILearnSchool.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDepartmentDescriptionToBeOptional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "504133be-4842-4bdd-9ebb-ac4e08bf01dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dae4519-6004-4b48-84be-32964bc7398d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "965e20f6-c336-4d79-8371-9b1e17a4da03");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a0572b15-be88-41af-b858-7dc4182c94a1", null, "Guest", "GUEST" },
                    { "c5965a9e-04b4-4aee-9218-72a94e1b8489", null, "Admin", "ADMIN" },
                    { "e0ec821b-2d81-4fbf-9c80-c0e3b13091eb", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0572b15-be88-41af-b858-7dc4182c94a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5965a9e-04b4-4aee-9218-72a94e1b8489");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0ec821b-2d81-4fbf-9c80-c0e3b13091eb");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "504133be-4842-4bdd-9ebb-ac4e08bf01dd", null, "User", "USER" },
                    { "8dae4519-6004-4b48-84be-32964bc7398d", null, "Admin", "ADMIN" },
                    { "965e20f6-c336-4d79-8371-9b1e17a4da03", null, "Guest", "GUEST" }
                });
        }
    }
}
