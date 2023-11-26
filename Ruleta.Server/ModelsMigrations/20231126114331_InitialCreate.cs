using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ruleta.Server.ModelsMigrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jugadores",
                columns: table => new
                {
                    clave_jugadores = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jugadores", x => x.clave_jugadores);
                });

            migrationBuilder.CreateTable(
                name: "nombres",
                columns: table => new
                {
                    clave = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_jugador_fk = table.Column<int>(type: "int", nullable: false),
                    casar_fk = table.Column<int>(type: "int", nullable: false),
                    besar_fk = table.Column<int>(type: "int", nullable: false),
                    coger_fk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nombres", x => x.clave);
                });

            migrationBuilder.CreateTable(
                name: "opciones",
                columns: table => new
                {
                    clave_opciones = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    foto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opciones", x => x.clave_opciones);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jugadores");

            migrationBuilder.DropTable(
                name: "nombres");

            migrationBuilder.DropTable(
                name: "opciones");
        }
    }
}
