using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    internal class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
          
        }

        public void Configure(EntityTypeBuilder<Usuario> builder)
        { 
        builder.ToTable("Usuario");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).HasColumnName("Nome").HasMaxLength(256);
            builder.Property(u => u.SenhaHash).HasColumnName("Senha").HasMaxLength(42);
            builder.Property(u => u.Email).HasColumnName("Email").HasMaxLength(255);

        }
    }
}