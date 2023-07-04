using System.ComponentModel.DataAnnotations;

namespace LagusImoveisWebII.Models.Dtos
{
    public class UserLoginDto
    {
        [Required(ErrorMessage = "User Name is required")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string senha { get; set; }
    }
}