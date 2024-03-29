using System.ComponentModel.DataAnnotations;

namespace TheBookCave.Models.ViewModels
{
    public class LogInViewModel
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}