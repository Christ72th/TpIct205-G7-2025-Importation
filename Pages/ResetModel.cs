using System.ComponentModel.DataAnnotations;

namespace Deliberation.Models
{
    public class ResetModel
    {
        [Required(ErrorMessage = "L'email est requis.")]
        [EmailAddress(ErrorMessage = "L'email n'est pas valide.")]
        public string Email { get; set; }

        // Vous pouvez ajouter d'autres propriétés si nécessaire
        // par exemple, pour un code de vérification
    }
}