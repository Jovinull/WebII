using LagusImoveisWebII.Context;
using LagusImoveisWebII.Models.Entites;
using LagusImoveisWebII.Repository.Interfaces;

namespace LagusImoveisWebII.Repository
{
    public class TipoSituacaoRepository : BaseRepository, ITipoSituacaoRepository
    {

        private readonly LagusImoveisWebIIContext _context;
        public TipoSituacaoRepository(LagusImoveisWebIIContext context) : base(context)
        {
            _context = context;
        }

        public Task<TipoSituacao> GetTipoSituacaoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
