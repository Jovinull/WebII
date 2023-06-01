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
            return await _context.Propriedade_tipo_modelSet
                .Select( x => new PropriedadeDto { 
                Id = x.Id,
                    Descricao = x.Descricao,
                    ImagemModel = x.ImagemModel,
                    UsuarioModel = new UsuarioModel {
                        Nome = x.UsuarioModel.Nome,
                        Telefone = x.UsuarioModel.Telefone},
                    Propriedade_tipo_situacaoModel = x.Propriedade_tipo_situacaoModel}).ToListAsync();

        }
    }
}
