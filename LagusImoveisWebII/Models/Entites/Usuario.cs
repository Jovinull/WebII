using Microsoft.AspNetCore.Identity;
using System.Xml.Linq;

namespace LagusImoveisWebII.Models.Entites
{
    public class Usuario : Base

    {
        public Usuario(string nome, string sobrenome, string email, string senha)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Senha = senha;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Senha { get; set; }
        public List<Propriedade> Propriedade { get; set; }

        
        }
        
    }

    