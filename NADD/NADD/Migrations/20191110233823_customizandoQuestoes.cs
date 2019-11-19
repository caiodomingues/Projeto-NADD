using Microsoft.EntityFrameworkCore.Migrations;

namespace NADD.Migrations
{
    public partial class customizandoQuestoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Clareza",
                table: "Questoes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Complexibilidade",
                table: "Questoes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Questoes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Clareza",
                table: "Questoes");

            migrationBuilder.DropColumn(
                name: "Complexibilidade",
                table: "Questoes");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Questoes");
        }
    }
}
