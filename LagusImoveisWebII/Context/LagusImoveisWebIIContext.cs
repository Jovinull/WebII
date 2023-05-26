using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace LagusImoveisWebII.Context
{
    public class LagusImoveisWebIIContext: DbContext
    {
        public LagusImoveisWebIIContext(DbContextOptions<LagusImoveisWebIIContext> options) : base(options) {}

        public DbSet<UsuarioModel> UsuarioSet { get; set; }
        public DbSet<EnderecoModel> EnderecoSet { get; set; }
        public DbSet<ImagemModel> ImagemSet { get; set; }
        public DbSet<Propriedade_tipo_situacaoModel> Propriedade_tipo_situacaoSet { get; set; }
        public DbSet<PropriedadeModel> Propriedade_tipo_modelSet { get; set; }
        public DbSet<Tipo_imovelModel> Tipo_ImovelModelSet { get; set; }
        public DbSet<Tipo_situacaoModel> Tipo_situacaoSet { get; set; }
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
