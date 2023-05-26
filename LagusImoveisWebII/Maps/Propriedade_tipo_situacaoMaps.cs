using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LagusImoveisWebII.Maps
{
    public class Propriedade_tipo_situacaoMaps : BaseMap<Propriedade_tipo_situacaoModel>
    {
        public Propriedade_tipo_situacaoMaps() : base("propriedade_tipo_situacao")
        {

        }
        public override void Configure(EntityTypeBuilder<Propriedade_tipo_situacaoModel> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Valor).HasColumnName("valor").HasPrecision(7,2).IsRequired();

            builder.Property(x => x.PropriedadeId).HasColumnName("id_propriedade").IsRequired();
            builder.HasOne(x => x.PropriedadeModel).WithOne().HasForeignKey<Propriedade_tipo_situacaoModel>(x => x.PropriedadeId).IsRequired();

            builder.Property(x => x.Tipo_situacaoId).HasColumnName("id_Tipo_situacao").IsRequired();
            builder.HasOne(x => x.Tipo_situacaoModel).WithOne().HasForeignKey<Propriedade_tipo_situacaoModel>(x => x.Tipo_situacaoId).IsRequired();



        }
    }
}

