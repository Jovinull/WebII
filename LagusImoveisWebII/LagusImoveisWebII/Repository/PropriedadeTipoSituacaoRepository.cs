using LagusImoveisWebII.Context;
using LagusImoveisWebII.Models.Entites;
using LagusImoveisWebII.Repository.Interfaces;

namespace LagusImoveisWebII.Repository
{
    public class PropriedadeTipoSituacaoRepository : BaseRepository, IPropriedadeTipoSituacaoRepository
    {

        private readonly LagusImoveisWebIIContext _context;
        public PropriedadeTipoSituacaoRepository(LagusImoveisWebIIContext context) : base(context)
        {
            _context = context;
        }

        public Task<PropriedadeTipoSituacao> GetPropriedadeTipoSituacaoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
