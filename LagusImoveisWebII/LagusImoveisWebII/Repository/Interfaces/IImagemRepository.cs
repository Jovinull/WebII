using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Repository.Interfaces
{

    public interface IImagemRepository : IBaseRepository
    {

        Task<Imagem> GetImagemByIdAsync(int id);
    }
}
