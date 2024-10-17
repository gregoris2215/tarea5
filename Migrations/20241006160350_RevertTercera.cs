using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tarea4.Migrations
{
    /// <inheritdoc />
    public partial class RevertTercera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Eliminar la columna 'Tipo' para revertir el cambio hecho en la migración 'tercera'
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "SeriePeliculaLibros");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Volver a añadir la columna 'Tipo' si se desea deshacer la reversión
            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "SeriePeliculaLibros",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}

