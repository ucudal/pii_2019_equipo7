﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace IgnisMercado.Migrations.Ignis
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competencia",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NivelBasicoOAvanzado = table.Column<string>(nullable: true),
                    PrecioPorHora = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencia", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ValoracionDelTrabajo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Propuesta",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    NivelDeDificultad = table.Column<string>(nullable: true),
                    EstimadoDeHora = table.Column<int>(nullable: false),
                    CostoEstimado = table.Column<int>(nullable: false),
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
                name: "Competencia");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Propuesta");
        }
    }
}