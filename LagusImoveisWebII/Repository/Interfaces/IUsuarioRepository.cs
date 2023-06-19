using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Repository.Interfaces
{

    public interface IUsuarioRepository : IBaseRepository
    {
        //lista todos os dados do usuário
        Task<Usuario> GetUsuarioByIdAsync(int id);



    }
}
