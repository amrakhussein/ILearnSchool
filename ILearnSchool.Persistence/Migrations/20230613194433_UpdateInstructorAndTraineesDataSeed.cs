using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ILearnSchool.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInstructorAndTraineesDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49cd9893-e48c-41a1-a093-1328517744cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d15b925-1be0-4e7f-af0c-393f4ff299dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc35d82f-21a2-4c4b-be05-bc6e5682d214");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "388d5bfe-632b-4075-b017-f7186fa3d41d", null, "Admin", "ADMIN" },
                    { "cba4c18e-7117-4ebb-9506-68366454001d", null, "User", "USER" },
                    { "f66b5fca-4daf-45be-9eb5-9a3419c8ce8b", null, "Guest", "GUEST" }
                });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Sophia", "Sophia" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Isabella", "Isabella" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 45, "David", "David" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 44, "Joseph", "Joseph" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 42, "Matthew", "Matthew" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "DepartmentId", "FirstName", "LastName" },
                values: new object[] { 36, 2, "John", "John" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "John", "John" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DepartmentId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 8, 28, 4, "Emily", "Emily" },
                    { 9, 35, 1, "Joseph", "Joseph" },
                    { 10, 35, 2, "Mia", "Mia" },
                    { 11, 31, 3, "Michael", "Michael" },
                    { 12, 34, 4, "Ava", "Ava" },
                    { 13, 43, 1, "William", "William" },
                    { 14, 31, 2, "John", "John" },
                    { 15, 39, 3, "Mia", "Mia" },
                    { 16, 30, 4, "Isabella", "Isabella" },
                    { 17, 33, 1, "Emily", "Emily" },
                    { 18, 43, 2, "Sarah", "Sarah" },
                    { 19, 49, 3, "Emma", "Emma" },
                    { 20, 35, 4, "Joseph", "Joseph" }
                });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Isabella", "Isabella" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Ava", "Ava" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Olivia", "Olivia" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Age",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "William", "William" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Matthew", "Matthew" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Ava", "Ava" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Matthew", "Matthew" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 33, "John", "John" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Jane", "Jane" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Michael", "Michael" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 30, "Michael", "Michael" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Sophia", "Sophia" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Emily", "Emily" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Sarah", "Sarah" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Daniel", "Daniel" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Emma", "Emma" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Jessica", "Jessica" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Emma", "Emma" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Isabella", "Isabella" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "388d5bfe-632b-4075-b017-f7186fa3d41d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba4c18e-7117-4ebb-9506-68366454001d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f66b5fca-4daf-45be-9eb5-9a3419c8ce8b");

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "49cd9893-e48c-41a1-a093-1328517744cb", null, "Admin", "ADMIN" },
                    { "7d15b925-1be0-4e7f-af0c-393f4ff299dd", null, "Guest", "GUEST" },
                    { "bc35d82f-21a2-4c4b-be05-bc6e5682d214", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 30, "Amr", "Samy" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Samy", "Ramy" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 40, "Jasmine", "Ahmed" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 45, "Ayman", "Akram" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 40, "Hatem", "Rady" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "DepartmentId", "FirstName", "LastName" },
                values: new object[] { 40, 3, "Haitham", "Nabil" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 40, "Nabil", "Samy" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 18, "John", "John" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Jane", "Jane" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 20, "Michael", "Michael" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Age",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "David", "David" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 23, "Sarah", "Sarah" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 24, "Daniel", "Daniel" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "Jessica", "Jessica" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Robert", "Robert" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 27, "Olivia", "Olivia" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "William", "William" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Sophia", "Sophia" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 30, "Joseph", "Joseph" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 31, "Emma", "Emma" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Matthew", "Matthew" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ava", "Ava" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Christopher", "Christopher" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Isabella", "Isabella" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Andrew", "Andrew" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Mia", "Mia" });
        }
    }
}
