using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections.Generic;

namespace LagusImoveisWebII.Models.Entites
{
 
    public class Imagem : Base
    {
        public byte[] Imagens { get; set; }

        public int PropriedadeId { get; set; }
        public Propriedade Propriedade { get; set; }



    }
}





