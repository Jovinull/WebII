using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LagusImoveisWebII.Maps
{
    public class ImagemMaps : BaseMap<ImagemModel>
    {
        public ImagemMaps() : base("imagem")
        {

        }
        public override void Configure(EntityTypeBuilder<ImagemModel> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Imagem).HasColumnName("imagem").HasColumnType("bytea").IsRequired();


           
            //builder.Property(x => x.PropriedadeId).HasColumnName("id_propriedade").IsRequired();
            //builder.HasOne(x => x.PropriedadeModel).WithMany(x =>x.ImagemModel).HasForeignKey(x => x.PropriedadeId).IsRequired();





        }
    }
}