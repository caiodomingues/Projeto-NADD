using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NADD.Migrations
{
    public partial class thobiasGOD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DisciplinaProfessor");

            migrationBuilder.DropIndex(
                name: "IX_Professor_CpfProfessor",
                table: "Professor");

            migrationBuilder.DropIndex(
                name: "IX_Professor_EmailProfessor",
                table: "Professor");

            migrationBuilder.DropIndex(
                name: "IX_Professor_NomeProfessor",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Avaliacao");

            migrationBuilder.DropColumn(
                name: "NomeAvaliador",
                table: "Avaliacao");

            migrationBuilder.RenameColumn(
                name: "HoraInicio",
                table: "Avaliacao",
                newName: "DtCriacao");

            migrationBuilder.RenameColumn(
                name: "HoraConclusao",
                table: "Avaliacao",
                newName: "DtAplicacao");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Questoes",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Questoes",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NomeProfessor",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EmailProfessor",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CpfProfessor",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtCriacao",
                table: "Disciplina",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Disciplina",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DtCriacao",
                table: "Curso",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Curso",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "ValorQuestExp",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "ValorProvaExp",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "RefBibliograficas",
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

            migrationBuilder.AddColumn<int>(
                name: "ProfessorId",
                table: "Avaliacao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacao_ProfessorId",
                table: "Avaliacao",
                column: "ProfessorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacao_Professor_ProfessorId",
                table: "Avaliacao",
                column: "ProfessorId",
                principalTable: "Professor",
                principalColumn: "ProfessorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacao_Professor_ProfessorId",
                table: "Avaliacao");

            migrationBuilder.DropIndex(
                name: "IX_Avaliacao_ProfessorId",
                table: "Avaliacao");

            migrationBuilder.DropColumn(
                name: "DtCriacao",
                table: "Disciplina");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Disciplina");

            migrationBuilder.DropColumn(
                name: "DtCriacao",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Curso");

            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Avaliacao");

            migrationBuilder.RenameColumn(
                name: "DtCriacao",
                table: "Avaliacao",
                newName: "HoraInicio");

            migrationBuilder.RenameColumn(
                name: "DtAplicacao",
                table: "Avaliacao",
                newName: "HoraConclusao");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Questoes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Questoes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeProfessor",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EmailProfessor",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CpfProfessor",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ValorQuestExp",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "ValorProvaExp",
                table: "Avaliacao",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "RefBibliograficas",
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

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Avaliacao",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeAvaliador",
                table: "Avaliacao",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "DisciplinaProfessor",
                columns: table => new
                {
                    DisciplinaId = table.Column<int>(nullable: false),
                    ProfessorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplinaProfessor", x => new { x.DisciplinaId, x.ProfessorId });
                    table.ForeignKey(
                        name: "FK_DisciplinaProfessor_Disciplina_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplina",
                        principalColumn: "DisciplinaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DisciplinaProfessor_Professor_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professor",
                        principalColumn: "ProfessorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Professor_CpfProfessor",
                table: "Professor",
                column: "CpfProfessor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Professor_EmailProfessor",
                table: "Professor",
                column: "EmailProfessor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Professor_NomeProfessor",
                table: "Professor",
                column: "NomeProfessor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DisciplinaProfessor_ProfessorId",
                table: "DisciplinaProfessor",
                column: "ProfessorId");
        }
    }
}
