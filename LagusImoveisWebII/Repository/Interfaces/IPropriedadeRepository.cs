using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;
using System.Threading.Tasks;

namespace LagusImoveisWebII.Repository.Interfaces
{
    public interface IPropriedadeRepository : IBaseRepository
    {
        Task<IEnumerable<Propriedade>> GetPropriedadeAsync (PropriedadeParamsDto parametro);
        Task<IEnumerable<Propriedade>> GetPropriedadeTodosAsync();

        Task<Propriedade> GetPropriedadeById(int id);


    }
}