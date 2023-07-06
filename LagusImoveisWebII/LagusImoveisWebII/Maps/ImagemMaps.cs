using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LagusImoveisWebII.Maps
{
    public class ImagemMaps : BaseMap<Imagem>
    {
        public ImagemMaps() : base("imagem")
        {

        }
        public override void Configure(EntityTypeBuilder<Imagem> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Imagens).HasColumnName("imagem").HasColumnType("text").IsRequired();

            builder.Property(x => x.PropriedadeId).HasColumnName("idPropriedade").IsRequired();
            builder.HasOne(x => x.Propriedade).WithMany(x => x.Imagem).HasForeignKey(x => x.PropriedadeId).IsRequired();





        }
    }
}