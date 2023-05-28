using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections.Generic;

namespace LagusImoveisWebII.Models.Entites
{
 
    public class ImagemModel : Base
    {
        public byte[] Imagem { get; set; }

        public int PropriedadeId { get; set; }
        
        //public PropriedadeModel PropriedadeModel { get; set; }

        public List<PropriedadeModel> PropriedadeModel { get; set; }

    }
    }

