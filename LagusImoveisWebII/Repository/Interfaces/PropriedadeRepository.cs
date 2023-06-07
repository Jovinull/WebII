using LagusImoveisWebII.Context;
using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace LagusImoveisWebII.Repository.Interfaces
{
    public class PropriedadeRepository : BaseRepository, IPropriedadeRepository
    {
      
        private readonly LagusImoveisWebIIContext _context;
        public PropriedadeRepository(LagusImoveisWebIIContext context): base(context){ 
            _context = context;
        }

       
        public async Task<IEnumerable<PropriedadeDto>>GetPropriedadeAsync()
        {
            return await _context.PropriedadeSet
                .Select( x => new PropriedadeDto { 
                Id = x.Id,
                    Descricao = x.Descricao,
                    Imagem = x.Imagem,
                    Usuario = new Usuario {
                        Nome = x.Usuario.Nome,
                        Telefone = x.Usuario.Telefone},
                    PropriedadeTipoSituacao = x.PropriedadeTipoSituacao}).ToListAsync();

        }
    }
}
