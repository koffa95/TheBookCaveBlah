using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheBookCave.Data;
using TheBookCave.Data.EntityModels;
using TheBookCave.Models;
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
        public IActionResult SignIn()
        {
            return View();
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
            //return View("../Home/Index");
            
        }
    }
}
