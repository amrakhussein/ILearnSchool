using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ILearnSchool.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRefreshTokenTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82668d86-f6d4-4241-8668-16cc1a3d506e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a59a3aa-3b06-4c61-b1f8-aaa24b8b7be1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a461a584-6ee8-4e9b-87d5-120cc359b277");

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevokedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d0c6102a-6d0b-48c5-ae2b-c11f016b6f17", null, "Instructor", "INSTRUCTOR" },
                    { "dd20d482-a4f7-4c41-9351-b90f6783c40d", null, "Trainee", "TRAINEE" },
                    { "de6d17c2-0a14-4a5d-b02a-a0678429f5a8", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 60 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 50 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 60 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                column: "PassingGrade",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Sarah", "Davis" });

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Matthew", "Harris" });

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "Mia", "Robinson" });

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Sophia", "Thomas" });

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 47, "Joseph", "Jackson" });

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 49, "John", "Smith" });

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "David", "Brown" });

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 47, "Jane", "Johnson" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 38, new DateTime(2023, 6, 19, 22, 27, 18, 33, DateTimeKind.Local).AddTicks(7487), "Emma", "White" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 37, new DateTime(2023, 6, 19, 22, 27, 18, 33, DateTimeKind.Local).AddTicks(7532), "Emily", "Jones" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 18, new DateTime(2023, 6, 19, 22, 27, 18, 33, DateTimeKind.Local).AddTicks(7537), "Daniel", "Miller" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 33, new DateTime(2023, 6, 19, 22, 27, 18, 33, DateTimeKind.Local).AddTicks(7542), "Emma", "White" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 38, new DateTime(2023, 6, 19, 22, 27, 18, 33, DateTimeKind.Local).AddTicks(7547), "David", "Brown" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 29, new DateTime(2023, 6, 19, 22, 27, 18, 33, DateTimeKind.Local).AddTicks(7567), "Joseph", "Jackson" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 35, new DateTime(2023, 6, 19, 22, 27, 18, 33, DateTimeKind.Local).AddTicks(7572), "Sarah", "Davis" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 26, new DateTime(2023, 6, 19, 22, 27, 18, 33, DateTimeKind.Local).AddTicks(7576), "Isabella", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 33, new DateTime(2023, 6, 19, 22, 27, 18, 33, DateTimeKind.Local).AddTicks(7580), "Jessica", "Wilson" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 32, new DateTime(2023, 6, 19, 22, 27, 18, 33, DateTimeKind.Local).AddTicks(7585), "Sophia", "Thomas" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0c6102a-6d0b-48c5-ae2b-c11f016b6f17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd20d482-a4f7-4c41-9351-b90f6783c40d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de6d17c2-0a14-4a5d-b02a-a0678429f5a8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "82668d86-f6d4-4241-8668-16cc1a3d506e", null, "Instructor", "INSTRUCTOR" },
                    { "8a59a3aa-3b06-4c61-b1f8-aaa24b8b7be1", null, "Admin", "ADMIN" },
                    { "a461a584-6ee8-4e9b-87d5-120cc359b277", null, "Trainee", "TRAINEE" }
                });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 60 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 60 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 60 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 70 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", 50 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "PassingGrade" },
                values: new object[] { "unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto", 60 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Sed ut perspiciatis unde omnis totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                column: "PassingGrade",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 38, "William", "Anderson" });

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Isabella", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Sarah", "Davis" });

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 32, "Mia", "Robinson" });

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 39, "Jane", "Johnson" });

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 28, "Olivia", "Taylor" });

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 45, "Olivia", "Taylor" });

            migrationBuilder.UpdateData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 45, "William", "Anderson" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 27, new DateTime(2023, 6, 19, 5, 34, 23, 430, DateTimeKind.Local).AddTicks(5711), "William", "Anderson" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 36, new DateTime(2023, 6, 19, 5, 34, 23, 430, DateTimeKind.Local).AddTicks(5752), "David", "Brown" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 33, new DateTime(2023, 6, 19, 5, 34, 23, 430, DateTimeKind.Local).AddTicks(5757), "Isabella", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 30, new DateTime(2023, 6, 19, 5, 34, 23, 430, DateTimeKind.Local).AddTicks(5761), "Daniel", "Miller" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 20, new DateTime(2023, 6, 19, 5, 34, 23, 430, DateTimeKind.Local).AddTicks(5765), "Mia", "Robinson" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 23, new DateTime(2023, 6, 19, 5, 34, 23, 430, DateTimeKind.Local).AddTicks(5827), "William", "Anderson" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 27, new DateTime(2023, 6, 19, 5, 34, 23, 430, DateTimeKind.Local).AddTicks(5832), "Ava", "Martin" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 24, new DateTime(2023, 6, 19, 5, 34, 23, 430, DateTimeKind.Local).AddTicks(5836), "Emily", "Jones" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 32, new DateTime(2023, 6, 19, 5, 34, 23, 430, DateTimeKind.Local).AddTicks(5840), "Emily", "Jones" });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "EnrollmentDate", "FirstName", "LastName" },
                values: new object[] { 27, new DateTime(2023, 6, 19, 5, 34, 23, 430, DateTimeKind.Local).AddTicks(5845), "Sarah", "Davis" });
        }
    }
}
