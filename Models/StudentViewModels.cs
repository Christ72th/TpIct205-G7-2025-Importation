using System.ComponentModel.DataAnnotations;

namespace Deliberation.Models;

public class StudentLoginModel
{
    [Required(ErrorMessage = "Le matricule est requis")]
    //[RegularExpression(@"^\d{2}[a-zA-Z]\d{4}$", ErrorMessage = "Le matricule doit contenir respecter [11A1111]")]
    public string Matricule { get; set; } = string.Empty;
    /*[Required(ErrorMessage = "Le mot de passe est requis")]
    public string  { get; set; } = string.Empty;*/
}

public class StudentRegisterModel
{
    [Required(ErrorMessage = "Le prénom est requis")]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Le nom est requis")]
    public string LastName { get; set; } = string.Empty;

    [Required(ErrorMessage = "L'email est requis")]
    [EmailAddress(ErrorMessage = "Format d'email invalide")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Le matricule est requis")]
    //[RegularExpression(@"^2̣[a-zA-Z]4̣$", ErrorMessage = "Le matricule doit contenir respecter [11A1111]")]
    public string Matricule { get; set; } = string.Empty;

    [Required(ErrorMessage = "Le niveau est requis")]
    public string Level { get; set; } = string.Empty;


    [RegularExpression(@"^\d{9}$", ErrorMessage = "Le numéro doit contenir 9 chiffres")]
    [Required(ErrorMessage = "Le numéro de téléphone est requis")]
    public string PhoneNumber { get; set; } = string.Empty;


    [Required(ErrorMessage = "La date de naissance est requise")]
    public DateTime BirthDate { get; set; } = DateTime.Today;

    [Required(ErrorMessage = "La ville de naissance est requise")]
    public string CityOfBirth { get; set; } = string.Empty;
}
