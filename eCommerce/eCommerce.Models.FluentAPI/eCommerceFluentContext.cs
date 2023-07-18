using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Models.FluentAPI.Config;

namespace eCommerce.Models.FluentAPI
{
    internal class eCommerceFluentContext : DbContext
    {
        public eCommerceFluentContext(DbContextOptions<eCommerceFluentContext> options) : base(options)
        {

        }

        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Contato>? Contatos { get; set; }
        public DbSet<EnderecoEntrega>? EnderecosEntrega { get; set; }
        public DbSet<Departamento>? Departamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Explicações sobre FluentAPI
            modelBuilder.Entity<Usuario>().ToTable("TB_Usuarios");
            modelBuilder.Entity<Usuario>().Property(a => a.RG).HasColumnName("RegistroGeral").HasMaxLength(12).HasDefaultValue("RG-Ausente").IsRequired();
            modelBuilder.Entity<Usuario>().Ignore(a => a.Sexo);
            modelBuilder.Entity<Usuario>().Property(a => a.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Usuario>().HasIndex("CPF").IsUnique().HasFilter("[CPF] is not null").HasDatabaseName("IX_CPF_UNIQUE");
            modelBuilder.Entity<Usuario>().HasIndex(a => a.CPF);

            modelBuilder.Entity<Usuario>().HasIndex("CPF", "Email");
            modelBuilder.Entity<Usuario>().HasIndex(a => new {a.CPF, a.Email});

            modelBuilder.Entity<Usuario>().HasKey("Id");
            modelBuilder.Entity<Usuario>().HasKey(a => a.Id);

            modelBuilder.Entity<Usuario>().HasKey("Id", "CPF");
            modelBuilder.Entity<Usuario>().HasKey(a => new { a.Id, a.CPF });

            modelBuilder.Entity<Usuario>().HasAlternateKey(a => a.CPF);

            modelBuilder.Entity<Usuario>().HasNoKey();

            modelBuilder.Entity<Usuario>().HasOne(user => user.Contato).WithOne(ctto => ctto.Usuario).HasForeignKey<Contato>(a => a.UsuarioId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Usuario>().HasMany(user => user.EnderecosEntrega).WithOne(end => end.Usuario).HasForeignKey(end => end.UsuarioId);
            modelBuilder.Entity<Usuario>().HasMany(user => user.Departamentos).WithMany(dpto => dpto.Usuarios);

            modelBuilder.Entity<Usuario>().Property(a => a.RG).IsRequired().HasMaxLength(12);
            modelBuilder.Entity<Usuario>().Property(a => a.Preco).HasPrecision(2);
            #endregion


            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }
    }
}
