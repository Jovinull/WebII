using LagusImoveisWebII.Models.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LagusImoveisWebII.Context
{
    public class LagusImoveisWebIIContext : IdentityDbContext<IdentityUser>
    {
        public LagusImoveisWebIIContext(DbContextOptions<LagusImoveisWebIIContext> options) : base(options) { }

        public DbSet<Usuario> UsuarioSet { get; set; }
        public DbSet<Endereco> EnderecoSet { get; set; }
        public DbSet<Imagem> ImagemSet { get; set; }
        public DbSet<PropriedadeTipoSituacao> PropriedadeTipoSituacaoSet { get; set; }
        public DbSet<Propriedade> PropriedadeSet { get; set; }
        public DbSet<TipoImovel> TipoImovelSet { get; set; }
        public DbSet<TipoSituacao> TipoSituacaoSet { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
