using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LagusImoveisWebII.Maps
{
    public class Tipo_imovelMaps : BaseMap<Tipo_imovelModel>
    {
        public Tipo_imovelMaps() : base("tipo_imovel")
        {

        }
        public override void Configure(EntityTypeBuilder<Tipo_imovelModel> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao).HasColumnName("descricao").HasColumnType("varchar(20)").IsRequired();

            builder.Property(x => x.PropriedadeId).HasColumnName("id_propriedade").IsRequired();
            builder.HasOne(x => x.PropriedadeModel).WithOne().HasForeignKey<Tipo_imovelModel>(x => x.PropriedadeId).IsRequired();


        }
    }
}

