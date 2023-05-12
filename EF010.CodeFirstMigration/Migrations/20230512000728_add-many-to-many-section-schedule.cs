using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF010.CodeFirstMigration.Migrations
{
    /// <inheritdoc />
    public partial class addmanytomanysectionschedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    SUN = table.Column<bool>(type: "bit", nullable: false),
                    MON = table.Column<bool>(type: "bit", nullable: false),
                    TUE = table.Column<bool>(type: "bit", nullable: false),
                    WED = table.Column<bool>(type: "bit", nullable: false),
                    THU = table.Column<bool>(type: "bit", nullable: false),
                    FRI = table.Column<bool>(type: "bit", nullable: false),
                    SAT = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionSchedules_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionSchedules_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "FRI", "MON", "SAT", "SUN", "THU", "TUE", "Title", "WED" },
                values: new object[,]
                {
                    { 1, false, true, false, true, true, true, "Daily", true },
                    { 2, false, false, false, true, true, true, "DayAfterDay", false },
                    { 3, false, true, false, false, false, false, "Twice-a-Week", true },
                    { 4, true, false, true, false, false, false, "Weekend", false },
                    { 5, true, true, true, true, true, true, "Compact", true }
                });

            migrationBuilder.InsertData(
                table: "SectionSchedules",
                columns: new[] { "Id", "EndTime", "ScheduleId", "SectionId", "StartTime" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 10, 0, 0, 0), 1, 1, new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, new TimeSpan(0, 18, 0, 0, 0), 3, 2, new TimeSpan(0, 14, 0, 0, 0) },
                    { 3, new TimeSpan(0, 15, 0, 0, 0), 4, 3, new TimeSpan(0, 10, 0, 0, 0) },
                    { 4, new TimeSpan(0, 12, 0, 0, 0), 1, 4, new TimeSpan(0, 10, 0, 0, 0) },
                    { 5, new TimeSpan(0, 18, 0, 0, 0), 1, 5, new TimeSpan(0, 16, 0, 0, 0) },
                    { 6, new TimeSpan(0, 10, 0, 0, 0), 2, 6, new TimeSpan(0, 8, 0, 0, 0) },
                    { 7, new TimeSpan(0, 14, 0, 0, 0), 3, 7, new TimeSpan(0, 11, 0, 0, 0) },
                    { 8, new TimeSpan(0, 14, 0, 0, 0), 4, 8, new TimeSpan(0, 10, 0, 0, 0) },
                    { 9, new TimeSpan(0, 18, 0, 0, 0), 4, 9, new TimeSpan(0, 16, 0, 0, 0) },
                    { 10, new TimeSpan(0, 15, 0, 0, 0), 3, 10, new TimeSpan(0, 12, 0, 0, 0) },
                    { 11, new TimeSpan(0, 11, 0, 0, 0), 5, 11, new TimeSpan(0, 9, 0, 0, 0) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SectionSchedules_ScheduleId",
                table: "SectionSchedules",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionSchedules_SectionId",
                table: "SectionSchedules",
                column: "SectionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SectionSchedules");

            migrationBuilder.DropTable(
                name: "Schedules");
        }
    }
}
