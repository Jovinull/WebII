using Microsoft.AspNetCore.Mvc;

namespace LagusImoveisWebII.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CadastroUsuarioController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Teste de requisicao");
        }
    }
}
