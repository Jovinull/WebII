using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections.Generic;

namespace LagusImoveisWebII.Models.Entites
{

    public class Tipo_imovelModel : Base
    {
  
        public string Descricao { get; set; }
        public int PropriedadeId { get; set; }
        public PropriedadeModel PropriedadeModel { get; set; }
    }
}
