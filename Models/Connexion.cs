using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Deliberation.Models;

namespace Deliberation.Pages
{
    public class ConnexionModel : PageModel
    {
        [BindProperty]
        public LoginModel Login { get; set; }

        public void OnGet()
        {
            // Initialiser si nécessaire
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Logique d'authentification ici
            // Par exemple : vérifier les informations d'identification

            return RedirectToPage("/"); // Rediriger après connexion réussie
        }
    }
}