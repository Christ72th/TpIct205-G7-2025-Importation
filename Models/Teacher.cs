using System.ComponentModel.DataAnnotations;

namespace Deliberation.Models;

public class Teacher : User
{
    [Required]
    public string TeachingUnit { get; set; } = string.Empty;

    [Required]
    [RegularExpression(@"^\d{5}$")]
    public string AccessCode { get; set; } = string.Empty;

    [Required]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*\d).{8,}$")]
    public string Password { get; set; } = string.Empty;

    [Required]
    [Phone]
    public string PhoneNumber { get; set; } = string.Empty;

    public string VerificationCode { get; set; } = string.Empty;
}
