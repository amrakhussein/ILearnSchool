using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ILearnSchool.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTraineesDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "John", "John" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jane", "Jane" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Michael", "Michael" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 21, "Emily", "Emily" });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "Age", "DepartmentId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 5, 22, 1, "David", "David" },
                    { 6, 23, 2, "Sarah", "Sarah" },
                    { 7, 24, 3, "Daniel", "Daniel" },
                    { 8, 25, 4, "Jessica", "Jessica" },
                    { 9, 26, 1, "Robert", "Robert" },
                    { 10, 27, 2, "Olivia", "Olivia" },
                    { 11, 28, 3, "William", "William" },
                    { 12, 29, 4, "Sophia", "Sophia" },
                    { 13, 30, 1, "Joseph", "Joseph" },
                    { 14, 31, 2, "Emma", "Emma" },
                    { 15, 32, 3, "Matthew", "Matthew" },
                    { 16, 33, 4, "Ava", "Ava" },
                    { 17, 34, 1, "Christopher", "Christopher" },
                    { 18, 35, 2, "Isabella", "Isabella" },
                    { 19, 36, 3, "Andrew", "Andrew" },
                    { 20, 37, 4, "Mia", "Mia" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0165045c-5713-4e1a-8ad5-7bb5ea7cf5cb", null, "Admin", "ADMIN" },
                    { "030eec49-abf6-46ec-94bd-be1a8304a1db", null, "Guest", "GUEST" },
                    { "46d5f72c-d1df-4b88-a611-3a5fe1089cab", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Laila", "Mostapha" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ali", "Ahemd" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Omar", "Taha" });

            migrationBuilder.UpdateData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 22, "Akram", "Samy" });
        }
    }
}
