using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections.Generic;

namespace LagusImoveisWebII.Models.Entites
{
 
    public class Propriedade_tipo_situacaoModel : Base
    {

        public decimal Valor { get; set; }
        public int PropriedadeId { get; set; }
        public PropriedadeModel PropriedadeModel { get; set; }

        public int Tipo_situacaoId { get; set; }
        public Tipo_situacaoModel Tipo_situacaoModel { get; set; }
    }
}