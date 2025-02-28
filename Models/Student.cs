using System.ComponentModel.DataAnnotations;

namespace Deliberation.Models;

public class Student : User
{
    [Required]
    //[RegularExpression(@"^2̣[a-zA-Z]4̣$")]
    public string Matricule { get; set; } = string.Empty;

    [Required]
    public string Level { get; set; } = string.Empty;

    [Required]
    public DateTime BirthDate { get; set; }

    [Required]
    public string CityOfBirth { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

}
