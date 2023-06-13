using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ILearnSchool.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCourseDescriptionToBeOptional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bda97525-9d54-423b-ab5f-74e5a21fad2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebc8d955-2c22-43f6-86c3-04f87b631277");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3883c54-49b2-457a-a991-c8f85f2807d0");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Courses",
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
                    { "bda97525-9d54-423b-ab5f-74e5a21fad2e", null, "Admin", "ADMIN" },
                    { "ebc8d955-2c22-43f6-86c3-04f87b631277", null, "User", "USER" },
                    { "f3883c54-49b2-457a-a991-c8f85f2807d0", null, "Guest", "GUEST" }
                });
        }
    }
}
