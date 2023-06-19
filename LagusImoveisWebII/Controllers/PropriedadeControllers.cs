using LagusImoveisWebII.Models.Entites;
using LagusImoveisWebII.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using LagusImoveisWebII.Models.Dtos;

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

        // Lista todas as propriedades (home)
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var propriedade = await _repository.GetPropriedadeAsync();

            var propriedadesRetorno = _mapper.Map<IEnumerable<PropriedadeDto>>(propriedade);

            return propriedadesRetorno.Any()
                ? Ok(propriedadesRetorno)
                : BadRequest("Nenhuma propriedade encontrada.");
        }
    }
}
