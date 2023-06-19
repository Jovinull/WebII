namespace LagusImoveisWebII.Models.Entites
{
    public class Endereco: Base
    {
        public string Rua { get; set; }

        public string Numero { get; set; }
        public string Cep { get; set; }

        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public int PropriedadeId { get; set; }
        public Propriedade Propriedade { get; set; }


    }
}
