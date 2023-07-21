using eCommerce.Office.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Office
{
    public class eCommerceOfficeContext : DbContext
    {
        public DbSet<Colaborador> Colaboradores { get; set; } = null!;
        public DbSet<Setor> Setores { get; set; } = null!;
        public DbSet<Turma> Turmas { get; set; } = null!;
        public DbSet<Veiculo> Veiculos { get; set; } = null!;

        public DbSet<ColaboradorSetor>? ColaboradoresSetores { get; set; }

        // public DbSet<ColaboradorVeiculo>? ColaboradoresVeiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerceOffice;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapping: ColaboradorSetores (EF Core 3.1)
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

            #region Mapping: Colaborador <=> Turma (EF Core 5+)

            modelBuilder.Entity<Colaborador>().HasMany(a => a.Turmas).WithMany(a => a.Colaboradores);

            modelBuilder
                .Entity<Turma>()
                .HasData(
                    new Turma() { Id = 1, Nome = "Turma A1" },
                    new Turma() { Id = 2, Nome = "Turma A2" },
                    new Turma() { Id = 3, Nome = "Turma A3" },
                    new Turma() { Id = 4, Nome = "Turma A4" },
                    new Turma() { Id = 5, Nome = "Turma A5" }
                );

            #endregion

            #region Mapping: Colaborador <=> Veiculo + Payload (EF Core 5+)

            modelBuilder
                .Entity<Colaborador>()
                .HasMany(a => a.Veiculos)
                .WithMany(a => a.Colaboradores)
                .UsingEntity<ColaboradorVeiculo>(
                    q => q.HasOne(a => a.Veiculo)
                        .WithMany(a => a.ColaboradoresVeiculos)
                        .HasForeignKey(a => a.VeiculoId),
                    q => q.HasOne(a => a.Colaborador)
                        .WithMany(a => a.ColaboradoresVeiculos)
                        .HasForeignKey(a => a.ColaboradorId),
                    q => q.HasKey(a => new {a.ColaboradorId, a.VeiculoId})
                );
            ;
            
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

            modelBuilder.Entity<Veiculo>().HasData(
                new Veiculo() { Id = 1, Nome = "Fiat Argo", Placa = "ABC-1234" },
                new Veiculo() { Id = 2, Nome = "Fiat Mobi", Placa = "DEF-1234" },
                new Veiculo() { Id = 3, Nome = "Fiat Siena", Placa = "GHI-1234" },
                new Veiculo() { Id = 4, Nome = "Fiat Palio", Placa = "JKL-1234" },
                new Veiculo() { Id = 5, Nome = "Fiat Idea", Placa = "MNO-1234" }
                );
            #endregion

        }
    }
}
