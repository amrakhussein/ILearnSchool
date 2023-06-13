using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ILearnSchool.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCourseResultGradeDataTypeToDouble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "016f0e2d-566a-40b3-8c4a-a89d430a0309");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "760901e7-7e08-4bdf-ab9a-4cd8b251ce1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db86c111-d3e4-4c07-a0f0-59a1ad43de58");

            migrationBuilder.AlterColumn<double>(
                name: "Grade",
                table: "CourseResults",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bda97525-9d54-423b-ab5f-74e5a21fad2e", null, "Admin", "ADMIN" },
                    { "ebc8d955-2c22-43f6-86c3-04f87b631277", null, "User", "USER" },
                    { "f3883c54-49b2-457a-a991-c8f85f2807d0", null, "Guest", "GUEST" }
                });

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "Grade",
                value: 85.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "Grade",
                value: 77.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "Grade",
                value: 92.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "Grade",
                value: 80.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "Grade",
                value: 88.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 6,
                column: "Grade",
                value: 90.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 7,
                column: "Grade",
                value: 78.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 8,
                column: "Grade",
                value: 95.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 9,
                column: "Grade",
                value: 83.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 10,
                column: "Grade",
                value: 92.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 11,
                column: "Grade",
                value: 88.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 12,
                column: "Grade",
                value: 75.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 13,
                column: "Grade",
                value: 85.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 14,
                column: "Grade",
                value: 79.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 15,
                column: "Grade",
                value: 93.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 16,
                column: "Grade",
                value: 87.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 17,
                column: "Grade",
                value: 87.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 18,
                column: "Grade",
                value: 83.0);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 19,
                column: "Grade",
                value: 82.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "CourseResults",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "016f0e2d-566a-40b3-8c4a-a89d430a0309", null, "User", "USER" },
                    { "760901e7-7e08-4bdf-ab9a-4cd8b251ce1c", null, "Admin", "ADMIN" },
                    { "db86c111-d3e4-4c07-a0f0-59a1ad43de58", null, "Guest", "GUEST" }
                });

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "Grade",
                value: 85);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "Grade",
                value: 77);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "Grade",
                value: 92);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "Grade",
                value: 80);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "Grade",
                value: 88);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 6,
                column: "Grade",
                value: 90);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 7,
                column: "Grade",
                value: 78);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 8,
                column: "Grade",
                value: 95);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 9,
                column: "Grade",
                value: 83);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 10,
                column: "Grade",
                value: 92);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 11,
                column: "Grade",
                value: 88);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 12,
                column: "Grade",
                value: 75);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 13,
                column: "Grade",
                value: 85);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 14,
                column: "Grade",
                value: 79);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 15,
                column: "Grade",
                value: 93);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 16,
                column: "Grade",
                value: 87);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 17,
                column: "Grade",
                value: 87);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 18,
                column: "Grade",
                value: 83);

            migrationBuilder.UpdateData(
                table: "CourseResults",
                keyColumn: "Id",
                keyValue: 19,
                column: "Grade",
                value: 82);
        }
    }
}
