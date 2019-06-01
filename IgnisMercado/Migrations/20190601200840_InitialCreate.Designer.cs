﻿// <auto-generated />
using IgnisMercado.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IgnisMercado.Migrations
{
    [DbContext(typeof(IgnisContext))]
    [Migration("20190601200840_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("IgnisMercado.Models.Area", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RolEnAudioVisual");

                    b.HasKey("ID");

                    b.ToTable("Area");
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

                    b.Property<string>("DescripcionDeLaPropuesta");

                    b.Property<string>("Estado");

                    b.Property<string>("EstimadoPorHora");

                    b.Property<string>("ListaDeTecnicosPostulados");

                    b.Property<string>("NivelDeDificultad");

                    b.Property<string>("TecnicoAsignado");

                    b.HasKey("ID");

                    b.ToTable("Propuesta");
                });
#pragma warning restore 612, 618
        }
    }
}
