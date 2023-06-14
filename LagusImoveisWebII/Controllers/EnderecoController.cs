using LagusImoveisWebII.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LagusImoveisWebII.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnderecoController : ControllerBase
    {
       
            private readonly IEnderecoRepository _repository;


            public EnderecoController(IEnderecoRepository repository)
            {

                _repository = repository;

            }
        [HttpGet("{estado}")]
        public async Task<IActionResult> GetEnderecoByEstadoAsync (string estado)
        {
            var propriedades = await _repository.GetEnderecoByEstadoAsync(estado);

            return propriedades != null
                ? Ok(propriedades)
                : BadRequest("Propriedade não encontrada");
        }

    }
}
