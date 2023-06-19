using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LagusImoveisWebII.Maps
{
    public class TipoSituacaoMaps : BaseMap<TipoSituacao>
    {
        public TipoSituacaoMaps() : base("tipoSituacao")
        {

        }
        public override void Configure(EntityTypeBuilder<TipoSituacao> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao).HasColumnName("descricao").HasColumnType("varchar(30)").IsRequired();
           

        }
    }
}
