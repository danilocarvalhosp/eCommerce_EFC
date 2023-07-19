﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCommerce.Office;

#nullable disable

namespace eCommerce.Office.Migrations
{
    [DbContext(typeof(eCommerceOfficeContext))]
    [Migration("20230719232214_BancoInicial")]
    partial class BancoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ColaboradorTurma", b =>
                {
                    b.Property<int>("ColaboradoresId")
                        .HasColumnType("int");

                    b.Property<int>("TurmasId")
                        .HasColumnType("int");

                    b.HasKey("ColaboradoresId", "TurmasId");

                    b.HasIndex("TurmasId");

                    b.ToTable("ColaboradorTurma");
                });

            modelBuilder.Entity("ColaboradorVeiculo", b =>
                {
                    b.Property<int>("ColaboradoresId")
                        .HasColumnType("int");

                    b.Property<int>("VeiculosId")
                        .HasColumnType("int");

                    b.HasKey("ColaboradoresId", "VeiculosId");

                    b.HasIndex("VeiculosId");

                    b.ToTable("ColaboradorVeiculo");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colaboradores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Jose"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Maria"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Felipe"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Thiago"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Mariano"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Jessica"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Fernando"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Vivian"
                        });
                });

            modelBuilder.Entity("eCommerce.Office.Models.ColaboradorSetor", b =>
                {
                    b.Property<int>("SetorId")
                        .HasColumnType("int");

                    b.Property<int>("ColaboradorId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("DataCriacao")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("SetorId", "ColaboradorId");

                    b.HasIndex("ColaboradorId");

                    b.ToTable("ColaboradoresSetores");

                    b.HasData(
                        new
                        {
                            SetorId = 1,
                            ColaboradorId = 1,
                            DataCriacao = new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9934), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SetorId = 1,
                            ColaboradorId = 6,
                            DataCriacao = new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9957), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SetorId = 2,
                            ColaboradorId = 5,
                            DataCriacao = new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9959), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SetorId = 2,
                            ColaboradorId = 4,
                            DataCriacao = new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SetorId = 3,
                            ColaboradorId = 2,
                            DataCriacao = new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9961), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SetorId = 3,
                            ColaboradorId = 8,
                            DataCriacao = new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9962), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SetorId = 4,
                            ColaboradorId = 3,
                            DataCriacao = new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9964), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            SetorId = 4,
                            ColaboradorId = 7,
                            DataCriacao = new DateTimeOffset(new DateTime(2023, 7, 19, 20, 22, 14, 704, DateTimeKind.Unspecified).AddTicks(9965), new TimeSpan(0, -3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("eCommerce.Office.Models.Setor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Setores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Transporte"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Logistica"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Faturamento"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Financeiro"
                        });
                });

            modelBuilder.Entity("eCommerce.Office.Models.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("ColaboradorTurma", b =>
                {
                    b.HasOne("eCommerce.Office.Models.Colaborador", null)
                        .WithMany()
                        .HasForeignKey("ColaboradoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerce.Office.Models.Turma", null)
                        .WithMany()
                        .HasForeignKey("TurmasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ColaboradorVeiculo", b =>
                {
                    b.HasOne("eCommerce.Office.Models.Colaborador", null)
                        .WithMany()
                        .HasForeignKey("ColaboradoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerce.Office.Models.Veiculo", null)
                        .WithMany()
                        .HasForeignKey("VeiculosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCommerce.Office.Models.ColaboradorSetor", b =>
                {
                    b.HasOne("eCommerce.Office.Models.Colaborador", "Colaborador")
                        .WithMany("ColaboradoresSetores")
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerce.Office.Models.Setor", "Setor")
                        .WithMany("ColaboradoresSetores")
                        .HasForeignKey("SetorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colaborador");

                    b.Navigation("Setor");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Colaborador", b =>
                {
                    b.Navigation("ColaboradoresSetores");
                });

            modelBuilder.Entity("eCommerce.Office.Models.Setor", b =>
                {
                    b.Navigation("ColaboradoresSetores");
                });
#pragma warning restore 612, 618
        }
    }
}
