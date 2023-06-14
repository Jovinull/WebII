using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Models.Dtos
{
    public class PropriedadeDto
    {

        public int Id { get; set; }

        public string Descricao { get; set; }
        
        public List<ImagemDto> Imagem { get; set; }

        public TipoImovelDto TipoImovel { get; set; }

        public List<TipoSituacaoDto> TipoSituacao{ get; set; }

        public EnderecoDto Endereco { get; set; }

    }
}
