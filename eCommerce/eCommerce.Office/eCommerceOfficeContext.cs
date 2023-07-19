﻿using eCommerce.Office.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Office
{
    public class eCommerceOfficeContext : DbContext
    {
        public DbSet<Colaborador>? Colaboradores{ get; set; }
        public DbSet<Setor>? Setores { get; set; }
        public DbSet<Turma>? Turmas { get; set; }
        public DbSet<Veiculo>? Veiculos { get; set; }

        public DbSet<ColaboradorSetor>? ColaboradoresSetores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerceOffice;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region ColaboradorSetores
            modelBuilder.Entity<ColaboradorSetor>().HasKey(a => new { a.SetorId, a.ColaboradorId });

            modelBuilder
                .Entity<ColaboradorSetor>()
                .HasOne(a => a.Colaborador)
                .WithMany(a => a.ColaboradoresSetores)
                .HasForeignKey(a => a.ColaboradorId);

            modelBuilder
                .Entity<ColaboradorSetor>()
                .HasOne(a => a.Setor)
                .WithMany(a => a.ColaboradoresSetores)
                .HasForeignKey(a => a.SetorId);

            //modelBuilder.Entity<Colaborador>().HasMany<ColaboradorSetor>().WithOne(c => c.Colaborador).HasForeignKey(a => a.ColaboradorId);
            //modelBuilder.Entity<Setor>().HasMany<ColaboradorSetor>().WithOne(c => c.Setor).HasForeignKey(a => a.SetorId);
            #endregion

            #region Seeds
            modelBuilder
                .Entity<Colaborador>()
                .HasData(
                    new Colaborador() { Id = 1, Nome = "Jose" },
                    new Colaborador() { Id = 2, Nome = "Maria" },
                    new Colaborador() { Id = 3, Nome = "Felipe" },
                    new Colaborador() { Id = 4, Nome = "Thiago" },
                    new Colaborador() { Id = 5, Nome = "Mariano" },
                    new Colaborador() { Id = 6, Nome = "Jessica" },
                    new Colaborador() { Id = 7, Nome = "Fernando" },
                    new Colaborador() { Id = 8, Nome = "Vivian" }
                );
            modelBuilder
                .Entity<Setor>()
                .HasData(
                    new Setor() { Id = 1, Nome = "Transporte" },
                    new Setor() { Id = 2, Nome = "Logistica" },
                    new Setor() { Id = 3, Nome = "Faturamento" },
                    new Setor() { Id = 4, Nome = "Financeiro" }
                );

            modelBuilder
                .Entity<ColaboradorSetor>()
                .HasData(
                    new ColaboradorSetor() { SetorId = 1, ColaboradorId = 1, DataCriacao = DateTimeOffset.Now },
                    new ColaboradorSetor() { SetorId = 1, ColaboradorId = 6, DataCriacao = DateTimeOffset.Now },
                    new ColaboradorSetor() { SetorId = 2, ColaboradorId = 5, DataCriacao = DateTimeOffset.Now },
                    new ColaboradorSetor() { SetorId = 2, ColaboradorId = 4, DataCriacao = DateTimeOffset.Now },
                    new ColaboradorSetor() { SetorId = 3, ColaboradorId = 2, DataCriacao = DateTimeOffset.Now },
                    new ColaboradorSetor() { SetorId = 3, ColaboradorId = 8, DataCriacao = DateTimeOffset.Now },
                    new ColaboradorSetor() { SetorId = 4, ColaboradorId = 3, DataCriacao = DateTimeOffset.Now },
                    new ColaboradorSetor() { SetorId = 4, ColaboradorId = 7, DataCriacao = DateTimeOffset.Now }
                );
            #endregion
        }
    }
}
