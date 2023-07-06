using LagusImoveisWebII.Context;
using LagusImoveisWebII.Models.Dtos;
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

        public async Task<IEnumerable<Propriedade>> GetPropriedadeAsync(PropriedadeParamsDto parametro)
        {
            var propriedade = _context.PropriedadeSet
                .Include(x => x.PropriedadeTipoSituacao)
                .ThenInclude(x => x.TipoSituacao)
                .Include(x => x.Imagem)
                .Include(x => x.TipoImovel)
                .Include(x => x.Endereco)
                .AsQueryable();

            if (!string.IsNullOrEmpty(parametro.Descricao))
            {
                string Descricao = parametro.Descricao.ToLower().Trim();
                propriedade = propriedade.Where(x => x.Descricao.ToLower().Contains(Descricao));
            }

        

            return await propriedade.ToListAsync();
        }

        public async Task<IEnumerable<Propriedade>> GetPropriedadeTodosAsync()
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