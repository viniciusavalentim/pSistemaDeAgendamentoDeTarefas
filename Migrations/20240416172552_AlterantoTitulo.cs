using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrabalhandoComEntityFramework.Migrations
{
    public partial class AlterantoTitulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Título",
                table: "Tarefa",
                newName: "Titulo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Tarefa",
                newName: "Título");
        }
    }
}
