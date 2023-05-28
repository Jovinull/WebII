using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections.Generic;

namespace LagusImoveisWebII.Models.Entites
{
  
    public class PropriedadeModel : Base
    {
        public string Descricao { get; set; }
        public int UsuarioId { get; set; }
        public UsuarioModel UsuarioModel { get; set; }

        public int ImagemId { get; set; }
        public ImagemModel ImagemModel { get; set; }

    }
}
