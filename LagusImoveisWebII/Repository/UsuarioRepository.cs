using LagusImoveisWebII.Context;
using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace LagusImoveisWebII.Repository.Interfaces
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {

        private readonly LagusImoveisWebIIContext _context;
        public UsuarioRepository(LagusImoveisWebIIContext context) : base(context)
        {
            _context = context;
        }


        public async Task<Usuario> GetUsuarioByIdAsync(int id)
        {
            return await _context.UsuarioSet.Include(x => x.Propriedade)
                         .ThenInclude(c => c.PropriedadeTipoSituacao)
                        .Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
