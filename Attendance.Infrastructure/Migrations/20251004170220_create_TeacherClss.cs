using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class create_TeacherClss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "TeacherClass",
              columns: table => new
              {
                  TeacherId = table.Column<int>(type: "int", nullable: false),
                  ClassId = table.Column<int>(type: "int", nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_TeacherClass", x => new { x.TeacherId, x.ClassId });
                  table.ForeignKey(
                      name: "FK_TeacherClass_Class_ClassId",
                      column: x => x.ClassId,
                      principalTable: "Class",
                      principalColumn: "ClassId",
                      onDelete: ReferentialAction.NoAction);
                  table.ForeignKey(
                      name: "FK_TeacherClass_Teacher_TeacherId",
                      column: x => x.TeacherId,
                      principalTable: "Teacher",
                      principalColumn: "TeacherId",
                      onDelete: ReferentialAction.NoAction);
              });
            migrationBuilder.CreateIndex(
             name: "IX_TeacherClass_ClassId",
             table: "TeacherClass",
             column: "ClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
           name: "TeacherClass");

        }
    }
}
