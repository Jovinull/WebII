using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace LagusImoveisWebII.Maps
{
    public class PropriedadeMaps : BaseMap<Propriedade>
    {
        public PropriedadeMaps() : base("propriedade")
        {

        }
        public override void Configure(EntityTypeBuilder<Propriedade> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao).HasColumnName("descricao").HasColumnType("varchar(300)").IsRequired();



            builder.Property(x => x.UsuarioId).HasColumnName("idUsuario");
            builder.HasOne(x => x.Usuario).WithMany(x => x.Propriedade).HasForeignKey(x => x.UsuarioId);

            builder.Property(x => x.TipoImovelID).HasColumnName("idTipoImovel");
            builder.HasOne(x => x.TipoImovel).WithMany(x => x.Propriedade).HasForeignKey(x => x.TipoImovelID).IsRequired();

            builder.Property(x => x.EnderecoId).HasColumnName("idEndereco").IsRequired();
            builder.HasOne(x => x.Endereco).WithOne().HasForeignKey<Propriedade>(x => x.EnderecoId).IsRequired();



        }
    }
}
