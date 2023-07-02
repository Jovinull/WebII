using LagusImoveisWebII.Context;
using LagusImoveisWebII.Models.Entites;
using LagusImoveisWebII.Repository.Interfaces;

namespace LagusImoveisWebII.Repository
{
    public class TipoImovelRepository : BaseRepository, ITipoImovelRepository
    {

        private readonly LagusImoveisWebIIContext _context;
        public TipoImovelRepository(LagusImoveisWebIIContext context) : base(context)
        {
            _context = context;
        }

        public Task<TipoImovel> GetTipoImovelByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
    
}
