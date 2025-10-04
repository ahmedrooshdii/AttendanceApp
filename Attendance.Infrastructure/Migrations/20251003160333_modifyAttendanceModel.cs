using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class modifyAttendanceModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Attendance",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_ClassId",
                table: "Attendance",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Class_ClassId",
                table: "Attendance",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "ClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Class_ClassId",
                table: "Attendance");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_ClassId",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Attendance");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
