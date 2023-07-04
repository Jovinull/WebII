using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LagusImoveisWebII.Maps
{
    public class TipoImovelMaps : BaseMap<TipoImovel>
    {
        public TipoImovelMaps() : base("tipoImovel")
        {

        }
        public override void Configure(EntityTypeBuilder<TipoImovel> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao).HasColumnName("descricao").HasColumnType("varchar(20)").IsRequired();



        }
    }
}

