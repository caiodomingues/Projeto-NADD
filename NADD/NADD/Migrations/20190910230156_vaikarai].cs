using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NADD.Migrations
{
    public partial class vaikarai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DtCriacao",
                table: "Area",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DtCriacao",
                table: "Area");
        }
    }
}
