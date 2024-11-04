using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nemt.Migrations
{
    /// <inheritdoc />
    public partial class ChangeINti : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Tasks_TaskId",
                table: "Todos");

            migrationBuilder.AlterColumn<int>(
                name: "TaskId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "Name" },
                values: new object[] { 100, "MySuperAmazingTask" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "TodoId",
                keyValue: 1,
                column: "TaskId",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "TodoId",
                keyValue: 2,
                column: "TaskId",
                value: 100);

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Tasks_TaskId",
                table: "Todos",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Tasks_TaskId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 100);

            migrationBuilder.AlterColumn<int>(
                name: "TaskId",
                table: "Todos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "TodoId",
                keyValue: 1,
                column: "TaskId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "TodoId",
                keyValue: 2,
                column: "TaskId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Tasks_TaskId",
                table: "Todos",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId");
        }
    }
}
