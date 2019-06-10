﻿// <auto-generated />
using IgnisMercado.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IgnisMercado.Migrations.Ignis
{
    [DbContext(typeof(IgnisContext))]
    [Migration("20190609235617_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("IgnisMercado.Models.Competencia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NivelBasicoOAvanzado");

                    b.Property<string>("PrecioPorHora");

                    b.HasKey("ID");

                    b.ToTable("Competencia");
                });

            modelBuilder.Entity("IgnisMercado.Models.Feedback", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ValoracionDelTrabajo");

                    b.HasKey("ID");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("IgnisMercado.Models.Propuesta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CostoEstimado");

                    b.Property<string>("DescripcionDeLaPropuesta");

                    b.Property<string>("Estado");

                    b.Property<int>("EstimadoDeHora");

                    b.Property<string>("ListaDeTecnicosPostulados");

                    b.Property<string>("NivelDeDificultad");

                    b.Property<string>("TecnicoAsignado");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Propuesta");
                });
#pragma warning restore 612, 618
        }
    }
}
