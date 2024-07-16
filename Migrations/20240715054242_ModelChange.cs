using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityRegistrationCore.Migrations
{
    public partial class ModelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Professors_ProfessorId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_ProfessorId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Subjects");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Professors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_SubjectId",
                table: "Professors",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Professors_Subjects_SubjectId",
                table: "Professors",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professors_Subjects_SubjectId",
                table: "Professors");

            migrationBuilder.DropIndex(
                name: "IX_Professors_SubjectId",
                table: "Professors");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Professors");

            migrationBuilder.AddColumn<int>(
                name: "ProfessorId",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ProfessorId",
                table: "Subjects",
                column: "ProfessorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Professors_ProfessorId",
                table: "Subjects",
                column: "ProfessorId",
                principalTable: "Professors",
                principalColumn: "ProfessorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
