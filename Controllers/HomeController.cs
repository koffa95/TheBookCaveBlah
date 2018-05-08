using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheBookCave.Models;
using TheBookCave.Services;

namespace TheBookCave.Controllers
{
    public class HomeController : Controller
    {
        private AuthorService _authorService;
        private BookService _bookService;
        private UserService _userService;
        public HomeController()
        {
            _authorService = new AuthorService();
            _bookService = new BookService();
            _userService = new UserService();
        }
        public IActionResult Index()
        {
            var users = _userService.GetAllUsers();
            return View(users);
        }
        public IActionResult Books()
        {
            var books = _bookService.GetAllBooks();
            return View(books);
        }
        public IActionResult Authors()
        {
            var authors = _authorService.GetAllAuthors();
            return View(authors);
        }
    }
}
