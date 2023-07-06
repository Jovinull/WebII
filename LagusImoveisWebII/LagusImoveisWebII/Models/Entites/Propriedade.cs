using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections.Generic;

namespace LagusImoveisWebII.Models.Entites
{

    public class Propriedade : Base
    {

        public string Descricao { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public List<Imagem> Imagem { get; set; }
        public List<PropriedadeTipoSituacao> PropriedadeTipoSituacao { get; set; }

        public int TipoImovelID { get; set; }
        public TipoImovel TipoImovel { get; set; }

        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }







    }
}
