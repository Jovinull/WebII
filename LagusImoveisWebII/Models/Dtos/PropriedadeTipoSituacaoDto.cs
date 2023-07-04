using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Models.Dtos
{
    public class PropriedadeTipoSituacaoDto
    {
        public decimal Valor { get; set; }

        public TipoSituacaoDto TipoSituacao { get; set; }
    }
}
