using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TheBookCave.Models.ViewModels;

namespace TheBookCave.Controllers
{
    public class AuthorController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}