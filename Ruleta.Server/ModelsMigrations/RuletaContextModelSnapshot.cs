﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ruleta.Server.Models;

#nullable disable

namespace Ruleta.Server.ModelsMigrations
{
    [DbContext(typeof(RuletaContext))]
    partial class RuletaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ruleta.Server.Models.jugadores", b =>
                {
                    b.Property<int>("clave_jugadores")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("clave_jugadores"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("clave_jugadores");

                    b.ToTable("jugadores");
                });

            modelBuilder.Entity("Ruleta.Server.Models.nombres", b =>
                {
                    b.Property<int>("clave")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("clave"));

                    b.Property<int>("besar_fk")
                        .HasColumnType("int");

                    b.Property<int>("casar_fk")
                        .HasColumnType("int");

                    b.Property<int>("coger_fk")
                        .HasColumnType("int");

                    b.Property<int>("nombre_jugador_fk")
                        .HasColumnType("int");

                    b.HasKey("clave");

                    b.ToTable("nombres");
                });

            modelBuilder.Entity("Ruleta.Server.Models.opciones", b =>
                {
                    b.Property<int>("clave_opciones")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("clave_opciones"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("foto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("clave_opciones");

                    b.ToTable("opciones");
                });
#pragma warning restore 612, 618
        }
    }
}
