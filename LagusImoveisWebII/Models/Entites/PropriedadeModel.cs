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
       

    }
}
