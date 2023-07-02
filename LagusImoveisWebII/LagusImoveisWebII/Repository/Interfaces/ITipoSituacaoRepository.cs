using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Repository.Interfaces
{

    public interface ITipoSituacaoRepository : IBaseRepository
    {

        Task<TipoSituacao> GetTipoSituacaoByIdAsync(int id);
    }
}
