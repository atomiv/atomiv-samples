using Microsoft.EntityFrameworkCore.Migrations;

namespace TextAnalyzer.Tools.Migrator.Migrations
{
    public partial class AddedWordCount2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "WordCount",
                table: "Documents",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WordCount",
                table: "Documents");
        }
    }
}
