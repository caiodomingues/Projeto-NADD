using Microsoft.EntityFrameworkCore.Migrations;

namespace NADD.Migrations
{
    public partial class mexendoNosBagui : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ValorQuestExp",
                table: "Avaliacao",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "ValorProvaExp",
                table: "Avaliacao",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "RefBibliograficas",
                table: "Avaliacao",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Ppquestcontext",
                table: "Avaliacao",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "PQuestMultdisc",
                table: "Avaliacao",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Eqdistvquest",
                table: "Avaliacao",
                nullable: true,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "ValorQuestExp",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ValorProvaExp",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RefBibliograficas",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Ppquestcontext",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "PQuestMultdisc",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Eqdistvquest",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
