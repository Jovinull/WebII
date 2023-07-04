using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LagusImoveisWebII.Maps
{
    public class UsuarioMaps : BaseMap<Usuario>
    {
        public UsuarioMaps() : base("usuario")
        {

        }
        public override void Configure(EntityTypeBuilder<Usuario> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasColumnName("nome").HasColumnType("varchar(20)").IsRequired();
            builder.Property(x => x.Sobrenome).HasColumnName("sobrenome").HasColumnType("varchar(30)").IsRequired();
            builder.Property(x => x.Email).HasColumnName("email").HasColumnType("varchar(40)").IsRequired();

            builder.Property(x => x.Telefone).HasColumnName("telefone").HasColumnType("varchar(11)").IsRequired();

            builder.Property(x => x.Senha).HasColumnName("senha").HasColumnType("varchar(8)").IsRequired();

        }
    }
}

