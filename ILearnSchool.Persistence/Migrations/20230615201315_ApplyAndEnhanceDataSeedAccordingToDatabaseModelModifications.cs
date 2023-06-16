using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ILearnSchool.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ApplyAndEnhanceDataSeedAccordingToDatabaseModelModifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3513e4c6-b023-44c7-8081-356cea2ce4ab", null, "Admin", "ADMIN" },
                    { "3d748d0e-3d61-4187-b1a2-4455ce2e0fa1", null, "Guest", "GUEST" },
                    { "f9261bdb-0a47-4272-acda-7daff7197eff", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium", "Computer Science" },
                    { 2, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium", "Arts" },
                    { 3, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium", "Finance" },
                    { 4, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium", "Business" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "DepartmentId", "Description", "HighestGrade", "Name", "PassingGrade" },
                values: new object[,]
                {
                    { 1, 1, "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 100, "Course 1", 60 },
                    { 2, 2, "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 100, "Course 2", 50 },
                    { 3, 3, "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 100, "Course 3", 60 },
                    { 4, 4, "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 100, "Course 4", 50 },
                    { 5, 1, "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 100, "Course 5", 60 },
                    { 6, 2, "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 100, "Course 6", 50 },
                    { 7, 3, "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 100, "Course 7", 60 },
                    { 8, 4, "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 100, "Course 8", 50 },
                    { 9, 1, "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 100, "Course 9", 70 },
                    { 10, 2, "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 100, "Course 10", 70 },
                    { 11, 3, "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 100, "Course 11", 60 },
                    { 12, 4, "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 100, "Course 12", 60 },
                    { 13, 1, "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 100, "Course 13", 50 },
                    { 14, 2, "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 100, "Course 14", 70 },
                    { 15, 3, "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 100, "Course 15", 50 },
                    { 16, 4, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 100, "Course 16", 70 }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Age", "DepartmentId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 36, 1, "Mia", "Robinson" },
                    { 2, 41, 2, "Joseph", "Jackson" },
                    { 3, 29, 3, "David", "Brown" },
                    { 4, 32, 4, "Matthew", "Harris" },
                    { 5, 44, 1, "Olivia", "Taylor" },
                    { 6, 42, 2, "Michael", "Williams" },
                    { 7, 28, 3, "Mia", "Robinson" },
                    { 8, 28, 4, "Robert", "Sam" },
                    { 9, 28, 1, "Olivia", "Taylor" },
                    { 10, 28, 2, "Christopher", "Thompson" }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "Age", "DepartmentId", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 36, 1, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4326), "Isabella", "Garcia" },
                    { 2, 33, 2, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4362), "Emily", "Jones" },
                    { 3, 26, 3, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4368), "William", "Anderson" },
                    { 4, 24, 4, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4372), "Sarah", "Davis" },
                    { 5, 20, 1, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4376), "William", "Anderson" },
                    { 6, 22, 2, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4383), "Joseph", "Jackson" },
                    { 7, 28, 3, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4387), "Sarah", "Davis" },
                    { 8, 31, 4, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4391), "Robert", "Sam" },
                    { 9, 19, 1, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4395), "Matthew", "Harris" },
                    { 10, 30, 2, new DateTime(2023, 6, 15, 23, 13, 15, 498, DateTimeKind.Local).AddTicks(4400), "Jane", "Johnson" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "CourseId", "Grade", "TraineeId" },
                values: new object[,]
                {
                    { 1, 1, 60.0, 1 },
                    { 2, 2, 50.0, 2 },
                    { 3, 3, 40.0, 3 },
                    { 4, 4, 30.0, 4 },
                    { 5, 5, 77.0, 1 },
                    { 6, 6, 80.0, 2 },
                    { 7, 7, 90.0, 3 },
                    { 8, 8, 100.0, 4 },
                    { 9, 9, 86.299999999999997, 1 },
                    { 10, 10, 67.700000000000003, 2 },
                    { 11, 11, 97.5, 3 },
                    { 12, 12, 67.0, 4 },
                    { 13, 13, 88.0, 1 },
                    { 14, 14, 76.0, 2 },
                    { 15, 15, 65.0, 3 },
                    { 16, 16, 78.599999999999994, 4 },
                    { 17, 1, 55.0, 2 },
                    { 18, 1, 86.0, 3 },
                    { 19, 1, 76.799999999999997, 4 },
                    { 20, 12, 76.799999999999997, 5 },
                    { 21, 13, 76.799999999999997, 6 },
                    { 22, 14, 76.799999999999997, 7 },
                    { 23, 3, 76.799999999999997, 8 },
                    { 24, 1, 76.799999999999997, 9 },
                    { 25, 2, 76.799999999999997, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4);

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
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
