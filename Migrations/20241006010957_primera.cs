using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tarea4.Migrations
{
    /// <inheritdoc />
    public partial class primera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeriePeliculaLibros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Pais = table.Column<string>(type: "TEXT", nullable: false),
                    Idioma = table.Column<string>(type: "TEXT", nullable: false),
                    FotoUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Resumen = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriePeliculaLibros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apodo = table.Column<string>(type: "TEXT", nullable: false),
                    Raza = table.Column<string>(type: "TEXT", nullable: false),
                    edad = table.Column<int>(type: "INTEGER", nullable: false),
                    FotoUrl = table.Column<string>(type: "TEXT", nullable: false),
                    SeriePeliculaLibroId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personajes_SeriePeliculaLibros_SeriePeliculaLibroId",
                        column: x => x.SeriePeliculaLibroId,
                        principalTable: "SeriePeliculaLibros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_SeriePeliculaLibroId",
                table: "Personajes",
                column: "SeriePeliculaLibroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "SeriePeliculaLibros");
        }
    }
}
