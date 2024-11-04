using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemt.Migrations
{
    /// <inheritdoc />
    public partial class Whoopsis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_TaskId",
                table: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grades",
                table: "Grades");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Tasks");

            migrationBuilder.RenameTable(
                name: "Grades",
                newName: "Todos");

            migrationBuilder.RenameIndex(
                name: "IX_Grades_TaskId",
                table: "Todos",
                newName: "IX_Todos_TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Todos",
                table: "Todos",
                column: "TodoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Tasks_TaskId",
                table: "Todos",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Tasks_TaskId",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Todos",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "Todos",
                newName: "Grades");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "Students");

            migrationBuilder.RenameIndex(
                name: "IX_Todos_TaskId",
                table: "Grades",
                newName: "IX_Grades_TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grades",
                table: "Grades",
                column: "TodoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_TaskId",
                table: "Grades",
                column: "TaskId",
                principalTable: "Students",
                principalColumn: "TaskId");
        }
    }
}
