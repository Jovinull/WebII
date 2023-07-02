using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Repository.Interfaces
{

    public interface IEnderecoRepository : IBaseRepository
    {

        Task<Endereco> GetEndercoByIdAsync(int id);
    }
}
