using LagusImoveisWebII.Context;
using LagusImoveisWebII.Models.Entites;
using LagusImoveisWebII.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;


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
                .ThenInclude(x => x.TipoSituacao)
                .Include(x => x.Imagem)
                .Include(x => x.TipoImovel)
                .Include(x => x.Endereco)
                .Include(x => x.Usuario)
                .ToListAsync();
        }

        public async Task<Propriedade> GetPropriedadeById(int id)
        {
            return await _context.PropriedadeSet
                .Include(x => x.PropriedadeTipoSituacao)
                .ThenInclude(x => x.TipoSituacao)
                .Include(x => x.Imagem)
                .Include(x => x.TipoImovel)
                .Include(x => x.Endereco)
                 .Include(x => x.Usuario)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }

    }
}