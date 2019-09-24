using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoSolutionsApi.Migrations
{
    public partial class datatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "priority",
                table: "proposedTasks",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "priority",
                table: "dailyTasks",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "priority",
                table: "proposedTasks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "priority",
                table: "dailyTasks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
