using AutoMapper;
using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagusImoveisWebII.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropriedadeController : ControllerBase
    {
        private readonly IPropriedadeRepository _repository;
        private readonly IMapper _mapper;

        public PropriedadeController(IPropriedadeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // Retorna todas as propriedades sem os dados do usuario
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var propriedades = await _repository.GetPropriedadeTodosAsync();
            var propriedadesRetorno = _mapper.Map<IEnumerable<PropriedadeDto>>(propriedades);

            return propriedadesRetorno.Any()
                ? Ok(propriedadesRetorno)
                : BadRequest("Dados  não encontrado.");
        }

        // Retorna uma propriedade pelo ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPropriedadeById(int id)
        {
            if (id <= 0)
                return BadRequest("Consulta inválida");

            var propriedade = await _repository.GetPropriedadeById(id);
            var propriedadeRetorno = _mapper.Map<PropriedadeDto>(propriedade);

            return propriedadeRetorno != null 
                ? Ok(propriedadeRetorno) 
                :  BadRequest("Dados  não encontrado.");
        }

        //Filtro
        [HttpGet("filter")]
        public async Task<IActionResult> Get([FromQuery]PropriedadeParamsDto parametro)
        {
            var propriedades = await _repository.GetPropriedadeAsync(parametro);
            var propriedadesRetorno = _mapper.Map<IEnumerable<PropriedadeDto>>(propriedades);

            return propriedadesRetorno.Any()
                ? Ok(propriedadesRetorno) 
                : BadRequest("Dados  não encontrado.");
        }
    }
}
