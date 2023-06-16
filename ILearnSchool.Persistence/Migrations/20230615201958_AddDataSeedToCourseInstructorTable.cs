using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ILearnSchool.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDataSeedToCourseInstructorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3513e4c6-b023-44c7-8081-356cea2ce4ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d748d0e-3d61-4187-b1a2-4455ce2e0fa1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9261bdb-0a47-4272-acda-7daff7197eff");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6369925f-a799-4058-ab87-3cdf6149a706", null, "User", "USER" },
                    { "7358fcc9-ceb3-44f5-88ae-0fe487d489e2", null, "Guest", "GUEST" },
                    { "7e2faa1f-bbcf-430e-b1cf-895958146f75", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "CourseInstructor",
                columns: new[] { "CourseId", "InstructorId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 2 },
                    { 9, 3 },
                    { 10, 3 },
                    { 11, 3 },
                    { 12, 3 },
                    { 13, 4 },
                    { 14, 4 },
                    { 15, 4 },
                    { 16, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "PassingGrade",
                value: 50);

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
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 60 });

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
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

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
                column: "Description",
                value: "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");

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
                column: "PassingGrade",
                value: 60);

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
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

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
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Daniel", "Miller" });

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
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 37, "Emily", "Jones" });

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
                columns: new[] { "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2023, 6, 15, 23, 19, 57, 770, DateTimeKind.Local).AddTicks(6389), "Andrew", "Martinez" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3513e4c6-b023-44c7-8081-356cea2ce4ab", null, "Admin", "ADMIN" },
                    { "3d748d0e-3d61-4187-b1a2-4455ce2e0fa1", null, "Guest", "GUEST" },
                    { "f9261bdb-0a47-4272-acda-7daff7197eff", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "PassingGrade",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "PassingGrade",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 60 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 50 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 60 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 50 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 60 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 60 });

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
                column: "PassingGrade",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 36, "Mia", "Robinson" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 41, "Joseph", "Jackson" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "David", "Brown" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Matthew", "Harris" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Olivia", "Taylor" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 42, "Michael", "Williams" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Mia", "Robinson" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Robert", "Sam" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Olivia", "Taylor" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Christopher", "Thompson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 36, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4326), "Isabella", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 33, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4362), "Emily", "Jones" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 26, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4368), "William", "Anderson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 24, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4372), "Sarah", "Davis" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 20, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4376), "William", "Anderson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 22, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4383), "Joseph", "Jackson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 28, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4387), "Sarah", "Davis" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4391), "Robert", "Sam" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 19, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4395), "Matthew", "Harris" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 30, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4400), "Jane", "Johnson" });
        }
    }
}
