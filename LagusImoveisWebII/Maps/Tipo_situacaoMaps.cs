using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LagusImoveisWebII.Maps
{
    public class Tipo_situacaoMaps : BaseMap<Tipo_situacaoModel>
    {
        public Tipo_situacaoMaps() : base("tipo_situacao")
        {

        }
        public override void Configure(EntityTypeBuilder<Tipo_situacaoModel> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao).HasColumnName("descricao").HasColumnType("varchar(20)").IsRequired();
           

        }
    }
}
