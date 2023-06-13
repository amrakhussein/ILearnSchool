using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ILearnSchool.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInstructorDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0165045c-5713-4e1a-8ad5-7bb5ea7cf5cb", null, "Admin", "ADMIN" },
                    { "030eec49-abf6-46ec-94bd-be1a8304a1db", null, "Guest", "GUEST" },
                    { "46d5f72c-d1df-4b88-a611-3a5fe1089cab", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DepartmentId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 5, 40, 1, "Hatem", "Rady" },
                    { 6, 40, 3, "Haitham", "Nabil" },
                    { 7, 40, 3, "Nabil", "Samy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0165045c-5713-4e1a-8ad5-7bb5ea7cf5cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "030eec49-abf6-46ec-94bd-be1a8304a1db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46d5f72c-d1df-4b88-a611-3a5fe1089cab");

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 7);

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
    }
}
