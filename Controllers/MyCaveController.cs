using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheBookCave.Data;
using TheBookCave.Data.EntityModels;
using TheBookCave.Models;
using TheBookCave.Models.ViewModels;
using TheBookCave.Services;

namespace TheBookCave.Controllers
{
    public class MyCaveController : Controller
    {
        private CartService _cartService;
        public MyCaveController()
        {
            _cartService = new CartService();
        }
       [HttpPost]
        public ActionResult AddToCart(int bookId)
        {
            Console.Write(bookId);

            var newCart = new Cart() { bookId = bookId };
           
            var db = new DataContext();

            db.AddRange(newCart);
            db.SaveChanges();
            return this.Json(new { success = true });
        }
                public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult signUp(CustomerViewModel _customer)
        {
            if(!ModelState.IsValid) {return View();}
            return View();
        }
    }
}
