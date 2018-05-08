using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TheBookCave.Data.EntityModels;

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