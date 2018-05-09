using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TheBookCave.Data.EntityModels;
using System;
using TheBookCave.Services;

namespace TheBookCave.Controllers
{
    public class AuthorController: Controller
    {
        private AuthorService _authorService;
        public AuthorController()
        {
            _authorService = new AuthorService();
        }
        public IActionResult Index()
        {
            var authors = _authorService.GetAllAuthors();
            return View(authors);
        }
    }
}