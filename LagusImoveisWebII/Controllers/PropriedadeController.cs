
using LagusImoveisWebII.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LagusImoveisWebII.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropriedadeController: ControllerBase

    {
        private readonly IPropriedadeRepository _repository;
       
        public PropriedadeController(IPropriedadeRepository repository) {
            
            _repository= repository;
        
        }

        [HttpGet]
        public async Task<ActionResult> GetPropriedade() {
            var propriedades = await _repository.GetPropriedadeAsync();

            return propriedades.Any()
                ? Ok(propriedades)
               :BadRequest("Propriedade não encontrada") ;
        }
       
    }
}
