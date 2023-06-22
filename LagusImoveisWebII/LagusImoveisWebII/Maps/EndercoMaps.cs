using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LagusImoveisWebII.Maps
{
    public class EnderecoMaps : BaseMap<Endereco>
    {
        public EnderecoMaps() : base("endereco")
        {

        }
        public override void Configure(EntityTypeBuilder<Endereco> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Rua).HasColumnName("rua").HasColumnType("varchar(30)").IsRequired();

            builder.Property(x => x.Numero).HasColumnName("numero").HasColumnType("varchar(11)");
            builder.Property(x => x.Cep).HasColumnName("cep").HasColumnType("varchar(8)").IsRequired();

            builder.Property(x => x.Bairro).HasColumnName("bairro").HasColumnType("varchar(30)").IsRequired();
            builder.Property(x => x.Estado).HasColumnName("estado").HasColumnType("varchar(20)").IsRequired();
            builder.Property(x => x.Cidade).HasColumnName("cidade").HasColumnType("varchar(20)").IsRequired();


            builder.Property(x => x.PropriedadeId).HasColumnName("idPropriedade").IsRequired();
            builder.HasOne(x => x.Propriedade).WithOne().HasForeignKey<Endereco>(x => x.PropriedadeId).IsRequired();



        }
    }
}
