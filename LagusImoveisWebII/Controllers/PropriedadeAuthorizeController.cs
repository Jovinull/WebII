
using AutoMapper;
using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Models.Entites;
using LagusImoveisWebII.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagusImoveisWebII.Controllers
{

    //O USUARIO VAI PRECISAR TA AUTENTICADO
    [ApiController]
    [Route("api/[controller]")]
    public class PropriedadeAuthorizeController : ControllerBase
    {
        private readonly IPropriedadeRepository _repository;
        private readonly IMapper _mapper;

        public PropriedadeAuthorizeController(IPropriedadeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // Retorna todas as propriedades 
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var propriedades = await _repository.GetPropriedadeAsync();
            var propriedadesRetorno = _mapper.Map<IEnumerable<PropriedadeDetalhesDto>>(propriedades);

            return propriedadesRetorno.Any() ? Ok(propriedadesRetorno) : NotFound();
        }

        // Retorna uma propriedade pelo ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPropriedadeById(int id)
        {
            if (id <= 0)
                return BadRequest("Consulta inválida");

            var propriedade = await _repository.GetPropriedadeById(id);
            var propriedadeRetorno = _mapper.Map<PropriedadeDetalhesDto>(propriedade);

            return propriedadeRetorno != null ? Ok(propriedadeRetorno) : NotFound();
        }

        //corrigir
        [HttpPost]
        public async Task<IActionResult> Post (PropriedadeAdicionarDto propriedade)
        {
            if (propriedade == null) return BadRequest("Dados inválidos");

            var propriedadeAdicionar = _mapper.Map<Propriedade>( propriedade);

            _repository.Add(propriedadeAdicionar);

            return await  _repository.SaveChangesAsync()
                ? Ok ("Propriedade Cadastrada")
                : BadRequest("Erro ao cadastrar propriedade");

            

        }
        //corrigir 

        [HttpPut]
        public async Task<IActionResult> Put(int id, PropriedadeAtualizarDto propriedade) {

            if (propriedade == null)
                return BadRequest("Dados inválidos");

            var propriedadeBanco = await _repository.GetPropriedadeById(id);

            if (propriedadeBanco == null)
                return BadRequest("Dados não existem na base de dados");

            var propriedadeAtualizar = _mapper.Map(propriedade, propriedadeBanco);


            _repository.Update(propriedadeAtualizar);

                return await _repository.SaveChangesAsync()
                 ? Ok("Propriedade Cadastrada")
                : BadRequest("Erro ao cadastrar propriedade");

        }


        //deleta propriedade
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return BadRequest("Propriedade inválido");

            var propriedadeExcluir = await _repository.GetPropriedadeById(id);

            if (propriedadeExcluir == null) return NotFound("Propriedade não encontrada");

            _repository.Delete(propriedadeExcluir);

            return await _repository.SaveChangesAsync()
                 ? Ok("Propriedade deletada com sucesso")
                 : BadRequest("Erro ao deletar o Propriedade");
        }

    }
}
