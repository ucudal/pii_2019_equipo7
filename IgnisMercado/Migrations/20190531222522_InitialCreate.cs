using Microsoft.EntityFrameworkCore.Migrations;

namespace IgnisMercado.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Propuesta",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NivelDeDificultad = table.Column<string>(nullable: true),
                    EstimadoPorHora = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    DescripcionDeLaPropuesta = table.Column<string>(nullable: true),
                    ListaDeTecnicosPostulados = table.Column<string>(nullable: true),
                    TecnicoAsignado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propuesta", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Propuesta");
        }
    }
}
