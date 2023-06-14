using LagusImoveisWebII.Context;
using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace LagusImoveisWebII.Repository.Interfaces
{
    public class EnderecoRepository : BaseRepository, IEnderecoRepository
    {

        private readonly LagusImoveisWebIIContext _context;
        public EnderecoRepository(LagusImoveisWebIIContext context) : base(context)
        {
            _context = context;
        }

        //alterar toda COLEÇÃO
        public async Task<Endereco> GetEnderecoByEstadoAsync(string estado)
        {
            return await _context.EnderecoSet.Include(x => x.Propriedade).Where(x => x.Estado == estado).FirstOrDefaultAsync();
        }

    }
}


