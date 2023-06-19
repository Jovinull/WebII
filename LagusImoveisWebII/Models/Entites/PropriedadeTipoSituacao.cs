using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections.Generic;

namespace LagusImoveisWebII.Models.Entites
{
 
    public class PropriedadeTipoSituacao : Base
    {

        public decimal Valor { get; set; }

        public int PropriedadeId { get; set; }
        public int TipoSituacaoId { get; set; }
        public Propriedade Propriedade { get; set; }
        public TipoSituacao TipoSituacao { get; set; }
    }
}