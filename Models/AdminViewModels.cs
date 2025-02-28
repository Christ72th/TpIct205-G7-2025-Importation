using System.ComponentModel.DataAnnotations;

namespace Deliberation.Models;


public class AdminLoginModel
{
    [Required(ErrorMessage = "Le nom d'utilisateur est requis")]
    public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d).{8,}$", 
            ErrorMessage = "Le mot de passe doit contenir au moins 8 caractères, une lettre majuscule et un chiffre.")]
        public string Password { get; set; }
}

public class AdminResetModel
{
    [Required(ErrorMessage = "L'email est requis")]
    [EmailAddress(ErrorMessage = "Format d'email invalide")]
    public string Email { get; set; } = string.Empty;

    [RegularExpression(@"^\d{6}$", ErrorMessage = "Le code de vérification doit contenir 6 chiffres")]
    public string VerificationCode { get; set; } = string.Empty;

    [Required(ErrorMessage = "Le mot de passe est requis.")]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*\d).{8,}$", 
        ErrorMessage = "Le mot de passe doit contenir au moins 8 caractères, une lettre majuscule et un chiffre.")]
    public string NewPassword { get; set; }
}
