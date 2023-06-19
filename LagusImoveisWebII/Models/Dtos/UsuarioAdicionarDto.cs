using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Models.Dtos
{
    public class UsuarioAdicionarDto
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }

    }
}

