using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ILearnSchool.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInstructorAndTraineesDataSeedPuttingTheCorrectLastNameInsteadOfFirstName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d76ddaa-35a6-4351-a368-b8698a1c8347");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28609d8a-b858-4811-8045-203a4122d2b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d166d8e-49b1-4672-9a15-c2cf1af7e2dc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ab6644e8-556f-471e-a06a-d1a16d0a13bb", null, "User", "USER" },
                    { "cd1cca78-a6a7-4e51-b677-b8928d9fb51d", null, "Admin", "ADMIN" },
                    { "e448ce3b-a98f-4bdd-8e60-5b2cbe819500", null, "Guest", "GUEST" }
                });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Mia", "Robinson" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 45, "Jane", "Johnson" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 43, "Mia", "Robinson" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Sophia", "Thomas" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Andrew", "Martinez" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 49, "Matthew", "Harris" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 48, "Andrew", "Martinez" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Isabella", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 43, "Ava", "Martin" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 47, "David", "Brown" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Ava", "Martin" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "LastName" },
                values: new object[] { 36, "Jones" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Isabella", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Robert", "Sam" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Emily", "Jones" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Robert", "Sam" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Sophia", "Thomas" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 21, "Matthew", "Harris" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ava", "Martin" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "William", "Anderson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Sophia", "Thomas" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 30, "Christopher", "Thompson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 27, "John", "Smith" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Jane", "Johnson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Emma", "White" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Olivia", "Taylor" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Andrew", "Martinez" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Michael", "Williams" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Sophia", "Thomas" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Joseph", "Jackson" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab6644e8-556f-471e-a06a-d1a16d0a13bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd1cca78-a6a7-4e51-b677-b8928d9fb51d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e448ce3b-a98f-4bdd-8e60-5b2cbe819500");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d76ddaa-35a6-4351-a368-b8698a1c8347", null, "Guest", "GUEST" },
                    { "28609d8a-b858-4811-8045-203a4122d2b1", null, "Admin", "ADMIN" },
                    { "7d166d8e-49b1-4672-9a15-c2cf1af7e2dc", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 40, "Sophia", "Sophia" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Robert", "Robert" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Sophia", "Sophia" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 42, "Robert", "Robert" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Matthew", "Matthew" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 46, "Ava", "Ava" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 43, "Ava", "Ava" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Sarah", "Sarah" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Joseph", "Joseph" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Robert", "Robert" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Robert", "Robert" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "LastName" },
                values: new object[] { 22, "Emily" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "David", "David" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "David", "David" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Isabella", "Isabella" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "David", "David" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "John", "John" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "John", "John" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "William", "William" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "David", "David" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 30, "David", "David" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Jane", "Jane" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Olivia", "Olivia" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Daniel", "Daniel" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Robert", "Robert" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Emily", "Emily" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Matthew", "Matthew" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "John", "John" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "William", "William" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Emma", "Emma" });
        }
    }
}
