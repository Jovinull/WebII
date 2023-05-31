using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections.Generic;

namespace LagusImoveisWebII.Models.Entites
{
   
    public class Tipo_situacaoModel : Base
    {
        public string Descricao { get; set; }

        public List<Propriedade_tipo_situacaoModel> Propriedade_tipo_situacaoModel { get; set; }

    }
}
