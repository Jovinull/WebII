using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Repository.Interfaces
{

    public interface IPropriedadeRepository: IBaseRepository
    {
        //lista todas as propriedades
        Task<IEnumerable<PropriedadeDto>>GetPropriedadeAsync();
    }
}
