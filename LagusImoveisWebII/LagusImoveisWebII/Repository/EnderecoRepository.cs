using LagusImoveisWebII.Context;
using LagusImoveisWebII.Models.Entites;
using LagusImoveisWebII.Repository.Interfaces;

namespace LagusImoveisWebII.Repository
{
    public class EnderecoRepository : BaseRepository, IEnderecoRepository
    {

        private readonly LagusImoveisWebIIContext _context;
        public EnderecoRepository(LagusImoveisWebIIContext context) : base(context)
        {
            _context = context;
        }

        public Task<Endereco> GetEndercoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
