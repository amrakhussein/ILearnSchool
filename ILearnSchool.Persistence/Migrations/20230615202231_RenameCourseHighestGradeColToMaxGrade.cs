using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ILearnSchool.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RenameCourseHighestGradeColToMaxGrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6369925f-a799-4058-ab87-3cdf6149a706");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7358fcc9-ceb3-44f5-88ae-0fe487d489e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e2faa1f-bbcf-430e-b1cf-895958146f75");

            migrationBuilder.RenameColumn(
                name: "HighestGrade",
                table: "Courses",
                newName: "MaxGrade");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "534bbaf3-92fd-4818-aed3-4dbb7906833b", null, "Guest", "GUEST" },
                    { "78df8e40-83a5-49ef-a6d2-b03fe180628f", null, "User", "USER" },
                    { "9d5e3657-ba4d-4017-8ca7-91129e3aa6d2", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "PassingGrade",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 60 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "PassingGrade",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 70 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 70 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 60 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                column: "PassingGrade",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                column: "PassingGrade",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Michael", "Williams" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 33, "Emily", "Jones" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 41, "Robert", "Sam" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 40, "Sophia", "Thomas" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Age",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 41, "Jessica", "Wilson" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 46, "Michael", "Williams" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Sophia", "Thomas" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Michael", "Williams" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jane", "Johnson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 37, new DateTime(2023, 6, 15, 23, 22, 31, 558, DateTimeKind.Local).AddTicks(8133), "Isabella", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 25, new DateTime(2023, 6, 15, 23, 22, 31, 558, DateTimeKind.Local).AddTicks(8224), "Isabella", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 33, new DateTime(2023, 6, 15, 23, 22, 31, 558, DateTimeKind.Local).AddTicks(8229), "John", "Smith" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 18, new DateTime(2023, 6, 15, 23, 22, 31, 558, DateTimeKind.Local).AddTicks(8234), "Andrew", "Martinez" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 39, new DateTime(2023, 6, 15, 23, 22, 31, 558, DateTimeKind.Local).AddTicks(8237), "Michael", "Williams" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 29, new DateTime(2023, 6, 15, 23, 22, 31, 558, DateTimeKind.Local).AddTicks(8245), "Andrew", "Martinez" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 34, new DateTime(2023, 6, 15, 23, 22, 31, 558, DateTimeKind.Local).AddTicks(8249), "John", "Smith" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 27, new DateTime(2023, 6, 15, 23, 22, 31, 558, DateTimeKind.Local).AddTicks(8253), "Christopher", "Thompson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 39, new DateTime(2023, 6, 15, 23, 22, 31, 558, DateTimeKind.Local).AddTicks(8257), "Mia", "Robinson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 21, new DateTime(2023, 6, 15, 23, 22, 31, 558, DateTimeKind.Local).AddTicks(8262), "John", "Smith" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "534bbaf3-92fd-4818-aed3-4dbb7906833b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78df8e40-83a5-49ef-a6d2-b03fe180628f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d5e3657-ba4d-4017-8ca7-91129e3aa6d2");

            migrationBuilder.RenameColumn(
                name: "MaxGrade",
                table: "Courses",
                newName: "HighestGrade");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6369925f-a799-4058-ab87-3cdf6149a706", null, "User", "USER" },
                    { "7358fcc9-ceb3-44f5-88ae-0fe487d489e2", null, "Guest", "GUEST" },
                    { "7e2faa1f-bbcf-430e-b1cf-895958146f75", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "PassingGrade",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "PassingGrade",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 50 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                column: "PassingGrade",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 60 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 60 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                column: "PassingGrade",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 60 });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 48, "Emily", "Jones" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Olivia", "Taylor" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "John", "Smith" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "David", "Brown" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Age",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 40, "Andrew", "Martinez" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Joseph", "Jackson" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Isabella", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Joseph", "Jackson" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Emily", "Jones" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 23, new DateTime(2023, 6, 15, 23, 19, 57, 770, DateTimeKind.Local).AddTicks(6314), "William", "Anderson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 37, new DateTime(2023, 6, 15, 23, 19, 57, 770, DateTimeKind.Local).AddTicks(6355), "Robert", "Sam" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 18, new DateTime(2023, 6, 15, 23, 19, 57, 770, DateTimeKind.Local).AddTicks(6360), "Andrew", "Martinez" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 35, new DateTime(2023, 6, 15, 23, 19, 57, 770, DateTimeKind.Local).AddTicks(6365), "Joseph", "Jackson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 23, new DateTime(2023, 6, 15, 23, 19, 57, 770, DateTimeKind.Local).AddTicks(6370), "Mia", "Robinson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 32, new DateTime(2023, 6, 15, 23, 19, 57, 770, DateTimeKind.Local).AddTicks(6377), "Robert", "Sam" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 21, new DateTime(2023, 6, 15, 23, 19, 57, 770, DateTimeKind.Local).AddTicks(6382), "David", "Brown" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 31, new DateTime(2023, 6, 15, 23, 19, 57, 770, DateTimeKind.Local).AddTicks(6389), "Andrew", "Martinez" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 30, new DateTime(2023, 6, 15, 23, 19, 57, 770, DateTimeKind.Local).AddTicks(6393), "Olivia", "Taylor" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 24, new DateTime(2023, 6, 15, 23, 19, 57, 770, DateTimeKind.Local).AddTicks(6415), "Emily", "Jones" });
        }
    }
}
