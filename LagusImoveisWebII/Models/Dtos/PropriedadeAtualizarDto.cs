using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Models.Dtos
{
    public class PropriedadeAtualizarDto
    { //corrigir
        public string? Descricao { get; set; }
        public List<Imagem> Imagem { get; set; }

        public TipoImovel TipoImovel { get; set; }
        public List<PropriedadeTipoSituacao>   PropriedadeTipoSituacao { get; set; }
        public Endereco Endereco { get; set; }

    }
}
