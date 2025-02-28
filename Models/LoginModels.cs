using System.ComponentModel.DataAnnotations;

namespace Deliberation.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Le nom d'utilisateur est requis.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d).{8,}$", 
            ErrorMessage = "Le mot de passe doit contenir au moins 8 caractères, une lettre majuscule et un chiffre.")]
        public string Password { get; set; }
    }
}