using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Models.Dtos
{
    public class PropriedadeDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public UsuarioModel UsuarioModel { get; set; }

        public List<ImagemModel> ImagemModel { get; set; }
        public List<Propriedade_tipo_situacaoModel> Propriedade_tipo_situacaoModel { get; set; }


    }
}
