using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Models.Dtos
{
    public class PropriedadeDetalhesDto
    {
        public string Descricao { get; set; }

        public List<Imagem> Imagem { get; set; }
        public List<PropriedadeTipoSituacao> PropriedadeTipoSituacao { get; set; }

        public int TipoImovelID { get; set; }
        public TipoImovel TipoImovel { get; set; }


    }
}
