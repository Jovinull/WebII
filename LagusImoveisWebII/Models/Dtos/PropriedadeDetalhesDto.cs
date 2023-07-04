using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Models.Dtos
{
    public class PropriedadeDetalhesDto
    {


            public int Id { get; set; }
            public string Descricao { get; set; }
            public List<ImagemDto> Imagem { get; set; }
            public List<PropriedadeTipoSituacaoDto> PropriedadeTipoSituacao { get; set; }
            public TipoImovelDto TipoImovel { get; set; }
            public EnderecoDto Endereco { get; set; }
            public UsuarioDto Usuario { get; set; }



    }
}
