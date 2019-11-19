using Microsoft.EntityFrameworkCore.Migrations;

namespace NADD.Migrations
{
    public partial class vaikarai4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Area",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Area",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
