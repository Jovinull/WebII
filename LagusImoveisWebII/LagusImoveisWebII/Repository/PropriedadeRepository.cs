using LagusImoveisWebII.Context;
using LagusImoveisWebII.Models.Entites;
using LagusImoveisWebII.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LagusImoveisWebII.Repository
{
    public class PropriedadeRepository : BaseRepository, IPropriedadeRepository
    {
        private readonly LagusImoveisWebIIContext _context;

        public PropriedadeRepository(LagusImoveisWebIIContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Propriedade>> GetPropriedadeAsync()
        {
            return await _context.PropriedadeSet
                .Include(x => x.PropriedadeTipoSituacao)
                .ThenInclude( x => x.TipoSituacao)
                .Include(x => x.Imagem)
                .Include(x => x.TipoImovel)
                .ToListAsync();
        }

        public async Task<Propriedade> GetPropriedadeById(int id)
        {
            return await _context.PropriedadeSet
                .Include(x => x.PropriedadeTipoSituacao)
                .Include(x => x.Imagem)
                .Include(x => x.TipoImovel)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
