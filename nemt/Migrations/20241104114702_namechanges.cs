using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace nemt.Migrations
{
    /// <inheritdoc />
    public partial class namechanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "TodoId", "IsDone", "Name", "TaskId" },
                values: new object[,]
                {
                    { 1, true, "Brew coffee", null },
                    { 2, true, "Produce Software", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "TodoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "TodoId",
                keyValue: 2);
        }
    }
}
