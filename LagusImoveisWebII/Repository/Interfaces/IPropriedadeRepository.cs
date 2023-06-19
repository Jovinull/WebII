using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Repository.Interfaces
{
    public interface IPropriedadeRepository: IBaseRepository
    {
        Task<IEnumerable<Propriedade>> GetPropriedadeAsync();

        Task<Propriedade> GetPropriedadeById(int id);


}}
