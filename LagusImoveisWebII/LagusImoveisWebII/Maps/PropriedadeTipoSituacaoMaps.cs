using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LagusImoveisWebII.Maps
{
    public class PropriedadeTipoSituacaoMaps : BaseMap<PropriedadeTipoSituacao>
    {
        public PropriedadeTipoSituacaoMaps() : base("propriedade_tipo_situacao")
        {

        }
        public override void Configure(EntityTypeBuilder<PropriedadeTipoSituacao> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Valor).HasColumnName("valor").HasPrecision(7, 2).IsRequired();

            builder.Property(x => x.PropriedadeId).HasColumnName("idpropriedade").IsRequired();
            builder.HasOne(x => x.Propriedade).WithMany(x => x.PropriedadeTipoSituacao).HasForeignKey(x => x.PropriedadeId).IsRequired();


            builder.Property(x => x.TipoSituacaoId).HasColumnName("idTipoSituacao").IsRequired();
            builder.HasOne(x => x.TipoSituacao).WithMany(x => x.PropriedadeTipoSituacao).HasForeignKey(x => x.TipoSituacaoId).IsRequired();


        }
    }
}

