﻿// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace projeto_estacionamento.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220927144201_BancoInicialCondominio")]
    partial class BancoInicialCondominio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("API.Models.Morador", b =>
                {
                    b.Property<int>("MoradorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apartamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Bloco")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo_veiculo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Placa")
                        .HasColumnType("TEXT");

                    b.HasKey("MoradorId");

                    b.ToTable("moradores");
                });

            modelBuilder.Entity("API.Models.Vagas", b =>
                {
                    b.Property<int>("VagasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MoradorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("VagasId");

                    b.HasIndex("MoradorId");

                    b.ToTable("vagas");
                });

            modelBuilder.Entity("API.Models.Vagas", b =>
                {
                    b.HasOne("API.Models.Morador", "Morador")
                        .WithMany()
                        .HasForeignKey("MoradorId");

                    b.Navigation("Morador");
                });
#pragma warning restore 612, 618
        }
    }
}