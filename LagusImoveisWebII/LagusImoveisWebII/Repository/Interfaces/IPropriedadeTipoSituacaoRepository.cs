using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Repository.Interfaces
{

    public interface IPropriedadeTipoSituacaoRepository : IBaseRepository
    {
        
        Task<PropriedadeTipoSituacao> GetPropriedadeTipoSituacaoByIdAsync(int id);
    }
}
