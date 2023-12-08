﻿// <auto-generated />
using App.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Grafico.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231006131041_Login")]
    partial class Login
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("App.Models.Continente", b =>
                {
                    b.Property<int>("continenteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("continenteID");

                    b.ToTable("Continentes");
                });

            modelBuilder.Entity("App.Models.Pais", b =>
                {
                    b.Property<int>("IdPaises")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Capital")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Populacao")
                        .HasColumnType("TEXT");

                    b.Property<int>("continenteID")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdPaises");

                    b.HasIndex("continenteID");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("App.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Imagem")
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("App.Models.Pais", b =>
                {
                    b.HasOne("App.Models.Continente", "Continente")
                        .WithMany("Paises")
                        .HasForeignKey("continenteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Continente");
                });

            modelBuilder.Entity("App.Models.Continente", b =>
                {
                    b.Navigation("Paises");
                });
#pragma warning restore 612, 618
        }
    }
}
