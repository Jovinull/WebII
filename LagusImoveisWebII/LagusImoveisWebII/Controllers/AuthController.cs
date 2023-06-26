using LagusImoveisWebII.Models.Dtos;
using LagusImoveisWebII.Repository.WebApi.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace LagusImoveisWebII.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(UserLoginDto userLogin)
        {
            string username = userLogin.nome;
            string password = userLogin.senha;

            
            {
                var token = TokenService.GenerateToken(new Models.Entites.Usuario());
                return Ok(token);
            }

            return BadRequest("username or password invalid");
        }
    }
}
