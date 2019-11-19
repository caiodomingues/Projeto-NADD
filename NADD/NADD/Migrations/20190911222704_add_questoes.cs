using Microsoft.EntityFrameworkCore.Migrations;

namespace NADD.Migrations
{
    public partial class add_questoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NumeroQuestao",
                table: "Questoes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroQuestao",
                table: "Questoes");
        }
    }
}
