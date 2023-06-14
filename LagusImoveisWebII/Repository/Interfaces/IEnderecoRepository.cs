using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Repository.Interfaces
{
    public interface IEnderecoRepository
    {
        Task<Endereco> GetEnderecoByEstadoAsync(string estado);
    }
}
