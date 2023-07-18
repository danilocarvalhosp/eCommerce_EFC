using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace eCommerce.API.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("TB_Usuarios");
            builder.Property(a => a.RG).HasColumnName("RegistroGeral").HasMaxLength(12).HasDefaultValue("RG-Ausente").IsRequired();
            builder.Ignore(a => a.Sexo);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
        }
    }
}
