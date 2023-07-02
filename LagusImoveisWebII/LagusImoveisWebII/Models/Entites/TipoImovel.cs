using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections.Generic;

namespace LagusImoveisWebII.Models.Entites
{

    public class TipoImovel : Base
    {

        public string Descricao { get; set; }
        public List<Propriedade> Propriedade { get; set; }

    }
}
