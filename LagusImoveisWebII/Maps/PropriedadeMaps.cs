using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace LagusImoveisWebII.Maps
{
    public class PropriedadeMaps : BaseMap<PropriedadeModel>
    {
        public PropriedadeMaps() : base("propriedade")
        {

        }
        public override void Configure(EntityTypeBuilder<PropriedadeModel> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao).HasColumnName("descricao").HasColumnType("varchar(300)").IsRequired();



            builder.Property(x => x.UsuarioId).HasColumnName("id_usuario");
            builder.HasOne(x => x.UsuarioModel).WithMany(x => x.PropriedadeModel).HasForeignKey(x => x.UsuarioId); 


        }
    }
}
