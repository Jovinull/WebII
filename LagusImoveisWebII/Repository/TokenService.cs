namespace LagusImoveisWebII.Repository
{
    using LagusImoveisWebII.Models.Entites;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using Microsoft.IdentityModel.Tokens;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;

    namespace WebApi.Application.Services
    {
        
            public static class Settings
            {
                public static string Secret = "712bf8d5-3cda-46c8-bdbd-8ad43c137a76";
            }
            public static class TokenService
            {
                public static string GenerateToken(Usuario usuario)
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var key = Encoding.ASCII.GetBytes(Settings.Secret);
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim(ClaimTypes.Name, usuario.Nome.ToString())
                        }),
                        Expires = DateTime.UtcNow.AddHours(3),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    return tokenHandler.WriteToken(token);
                }
            }
        }

    }