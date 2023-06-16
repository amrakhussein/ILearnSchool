using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ILearnSchool.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataSeedToCourseInstructorAndTrainees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f3b0c04-2a9e-4a23-b7a0-9604bb931f0f", null, "Guest", "GUEST" },
                    { "2fd7a724-f043-43ca-b5fd-a3ddd2fa8517", null, "Admin", "ADMIN" },
                    { "5a886c81-8dc5-440d-964b-0c165be4a25a", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "CourseInstructor",
                columns: new[] { "CourseId", "InstructorId" },
                values: new object[,]
                {
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 4 },
                    { 8, 4 },
                    { 9, 5 },
                    { 10, 5 },
                    { 11, 6 },
                    { 12, 6 },
                    { 13, 7 },
                    { 14, 7 },
                    { 15, 8 },
                    { 16, 8 }
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
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 50 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

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
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 60 });

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
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 60 });

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
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 70 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 60 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 60 });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Jessica", "Wilson" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 44, "Robert", "Sam" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 48, "Isabella", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 48, "Daniel", "Miller" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Joseph", "Jackson" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "David", "Brown" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Daniel", "Miller" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 41, "Jane", "Johnson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 20, new DateTime(2023, 6, 16, 0, 45, 39, 761, DateTimeKind.Local).AddTicks(2718), "David", "Brown" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 30, new DateTime(2023, 6, 16, 0, 45, 39, 761, DateTimeKind.Local).AddTicks(2759), "Joseph", "Jackson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "EnrollmentDate" },
                values: new object[] { 22, new DateTime(2023, 6, 16, 0, 45, 39, 761, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2023, 6, 16, 0, 45, 39, 761, DateTimeKind.Local).AddTicks(2786), "Christopher", "Thompson" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 32, new DateTime(2023, 6, 16, 0, 45, 39, 761, DateTimeKind.Local).AddTicks(2790), "Sarah", "Davis" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 33, new DateTime(2023, 6, 16, 0, 45, 39, 761, DateTimeKind.Local).AddTicks(2798), "Michael", "Williams" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 23, new DateTime(2023, 6, 16, 0, 45, 39, 761, DateTimeKind.Local).AddTicks(2802), "Daniel", "Miller" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 20, new DateTime(2023, 6, 16, 0, 45, 39, 761, DateTimeKind.Local).AddTicks(2806), "Matthew", "Harris" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 27, new DateTime(2023, 6, 16, 0, 45, 39, 761, DateTimeKind.Local).AddTicks(2809), "Olivia", "Taylor" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 18, new DateTime(2023, 6, 16, 0, 45, 39, 761, DateTimeKind.Local).AddTicks(2815), "Olivia", "Taylor" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f3b0c04-2a9e-4a23-b7a0-9604bb931f0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fd7a724-f043-43ca-b5fd-a3ddd2fa8517");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a886c81-8dc5-440d-964b-0c165be4a25a");

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "CourseInstructor",
                keyColumns: new[] { "CourseId", "InstructorId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "534bbaf3-92fd-4818-aed3-4dbb7906833b", null, "Guest", "GUEST" },
                    { "78df8e40-83a5-49ef-a6d2-b03fe180628f", null, "User", "USER" },
                    { "9d5e3657-ba4d-4017-8ca7-91129e3aa6d2", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "CourseInstructor",
                columns: new[] { "CourseId", "InstructorId" },
                values: new object[,]
                {
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
                value: 70);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

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
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

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
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 41, "Daniel", "Miller" });

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

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DepartmentId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 9, 38, 1, "Michael", "Williams" },
                    { 10, 37, 2, "Jane", "Johnson" }
                });

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
                columns: new[] { "Age", "EnrollmentDate" },
                values: new object[] { 33, new DateTime(2023, 6, 15, 23, 22, 31, 558, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2023, 6, 15, 23, 22, 31, 558, DateTimeKind.Local).AddTicks(8234), "Andrew", "Martinez" });

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
    }
}
