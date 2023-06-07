﻿using LagusImoveisWebII.Models.Entites;

namespace LagusImoveisWebII.Models.Dtos
{
    public class PropriedadeDto
    {

        public int Id { get; set; }

        public string Descricao { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public List<Imagem> Imagem { get; set; }
        public List<PropriedadeTipoSituacao> PropriedadeTipoSituacao { get; set; }


        public int TipoImovelModelID { get; set; }
        public TipoImovel TipoImovel { get; set; }
    }
}
