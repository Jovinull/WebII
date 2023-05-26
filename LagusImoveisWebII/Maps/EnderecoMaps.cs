using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LagusImoveisWebII.Maps
{
    public class EnderecoMaps : BaseMap<EnderecoModel>
    {
        public EnderecoMaps() : base("endereco")
        {

        }
        public override void Configure(EntityTypeBuilder<EnderecoModel> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Rua).HasColumnName("rua").HasColumnType("varchar(30)").IsRequired();
            builder.Property(x => x.Numero).HasColumnName("numero").HasColumnType("integer");
            builder.Property(x => x.Cep).HasColumnName("cep").HasColumnType("integer").IsRequired();
            builder.Property(x => x.Bairro).HasColumnName("bairro").HasColumnType("varchar(30)").IsRequired();
            builder.Property(x => x.Estado).HasColumnName("estado").HasColumnType("varchar(20)").IsRequired();
            builder.Property(x => x.Cidade).HasColumnName("cidade").HasColumnType("varchar(20)").IsRequired();


            builder.Property(x => x.PropriedadeId).HasColumnName("id_propriedade").IsRequired();
            builder.HasOne(x => x.PropriedadeModel).WithOne().HasForeignKey<EnderecoModel>(x => x.PropriedadeId).IsRequired();



        }
    }
}
