using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoSolutionsApi.Migrations
{
    public partial class removedstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "dailyTasks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "dailyTasks",
                nullable: true);
        }
    }
}
