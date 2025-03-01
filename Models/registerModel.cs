using System;
using System.ComponentModel.DataAnnotations;

namespace Deliberation.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Le prénom est requis.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Le nom est requis.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "La date de naissance est requise.")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Le matricule est requis.")]
        public string Matricule { get; set; }

        [Required(ErrorMessage = "La ville de naissance est requise.")]
        public string BirthCity { get; set; }

        [Required(ErrorMessage = "L'email est requis.")]
        [EmailAddress(ErrorMessage = "L'email n'est pas valide.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le nom d'utilisateur est requis.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [StringLength(100, ErrorMessage = "Le mot de passe doit contenir au moins {2} caractères.", MinimumLength = 6)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Les mots de passe ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
    }
}