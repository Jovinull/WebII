using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Repository.Interfaces
{

    public interface ITipoImovelRepository : IBaseRepository
    {

        Task<TipoImovel> GetTipoImovelByIdAsync(int id);
    }
}
