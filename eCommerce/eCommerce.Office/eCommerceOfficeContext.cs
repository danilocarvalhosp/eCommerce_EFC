using eCommerce.Office.Models;
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
            modelBuilder.Entity<ColaboradorSetor>().HasKey(a => new { a.SetorId, a.ColaboradorId });
            modelBuilder.Entity<Colaborador>().HasMany<ColaboradorSetor>().WithOne(c => c.Colaborador).HasForeignKey(a => a.ColaboradorId);
            modelBuilder.Entity<Setor>().HasMany<ColaboradorSetor>().WithOne(c => c.Setor).HasForeignKey(a => a.SetorId);
        }
    }
}
