using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF010.CodeFirstMigration.Migrations
{
    /// <inheritdoc />
    public partial class SplitInstructorName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Instructors");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "Instructors",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "Instructors",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FName", "LName" },
                values: new object[] { "Ahmed", "Abdullah" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FName", "LName" },
                values: new object[] { "Yasmeen", "Yasmeen" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FName", "LName" },
                values: new object[] { "Khalid", "Hassan" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FName", "LName" },
                values: new object[] { "Nadia", "Ali" });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FName", "LName" },
                values: new object[] { "Ahmed", "Abdullah" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FName",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "Instructors");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Instructors",
                type: "VARCHAR(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Ahmed Abdullah");

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Yasmeen Mohammed");

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Khalid Hassan");

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Nadia Ali");

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Omar Ibrahim");
        }
    }
}
