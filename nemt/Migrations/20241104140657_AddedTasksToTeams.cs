using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace nemt.Migrations
{
    /// <inheritdoc />
    public partial class AddedTasksToTeams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentToDoTodoId",
                table: "Workers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkerId",
                table: "Todos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentTaskId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 100,
                column: "TeamId",
                value: null);

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "Name", "TeamId" },
                values: new object[,]
                {
                    { 98, "MySuperAmazingTask2", null },
                    { 99, "MySuperAmazingTask1", null }
                });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "CurrentTaskId",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "CurrentTaskId",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "CurrentTaskId",
                value: 98);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "TodoId",
                keyValue: 1,
                column: "WorkerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "TodoId",
                keyValue: 2,
                column: "WorkerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "WorkerId",
                keyValue: 1,
                column: "CurrentToDoTodoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "WorkerId",
                keyValue: 2,
                column: "CurrentToDoTodoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "WorkerId",
                keyValue: 3,
                column: "CurrentToDoTodoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "WorkerId",
                keyValue: 4,
                column: "CurrentToDoTodoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "WorkerId",
                keyValue: 5,
                column: "CurrentToDoTodoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "WorkerId",
                keyValue: 6,
                column: "CurrentToDoTodoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "WorkerId",
                keyValue: 7,
                column: "CurrentToDoTodoId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Workers_CurrentToDoTodoId",
                table: "Workers",
                column: "CurrentToDoTodoId");

            migrationBuilder.CreateIndex(
                name: "IX_Todos_WorkerId",
                table: "Todos",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CurrentTaskId",
                table: "Teams",
                column: "CurrentTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TeamId",
                table: "Tasks",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Teams_TeamId",
                table: "Tasks",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Tasks_CurrentTaskId",
                table: "Teams",
                column: "CurrentTaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Workers_WorkerId",
                table: "Todos",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_Todos_CurrentToDoTodoId",
                table: "Workers",
                column: "CurrentToDoTodoId",
                principalTable: "Todos",
                principalColumn: "TodoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Teams_TeamId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Tasks_CurrentTaskId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Workers_WorkerId",
                table: "Todos");

            migrationBuilder.DropForeignKey(
                name: "FK_Workers_Todos_CurrentToDoTodoId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_CurrentToDoTodoId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Todos_WorkerId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Teams_CurrentTaskId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TeamId",
                table: "Tasks");

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 99);

            migrationBuilder.DropColumn(
                name: "CurrentToDoTodoId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "WorkerId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "CurrentTaskId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Tasks");
        }
    }
}
