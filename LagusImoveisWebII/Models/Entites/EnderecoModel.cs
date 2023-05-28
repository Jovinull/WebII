namespace LagusImoveisWebII.Models.Entites
{
    public class EnderecoModel: Base
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public int PropriedadeId { get; set; }
        public PropriedadeModel PropriedadeModel { get; set; }


    }
}
