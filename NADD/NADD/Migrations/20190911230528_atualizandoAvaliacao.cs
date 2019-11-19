using Microsoft.EntityFrameworkCore.Migrations;

namespace NADD.Migrations
{
    public partial class atualizandoAvaliacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Ppquestcontext",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ppquestcontext",
                table: "Avaliacao",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
