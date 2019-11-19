using Microsoft.EntityFrameworkCore.Migrations;

namespace NADD.Migrations
{
    public partial class subindoCoisas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Contextualizada",
                table: "Questoes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contextualizada",
                table: "Questoes");
        }
    }
}
