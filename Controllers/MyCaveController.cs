using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheBookCave.Models;
using TheBookCave.Models.ViewModels;
using TheBookCave.Services;

namespace TheBookCave.Controllers
{
    public class MyCaveController : Controller
    {
        private CustomerService _customerService;
        public MyCaveController()
        {
            _customerService = new CustomerService();
        }
        public IActionResult signIn()
        {
            return View();
        }
        [HttpGet]
        public IActionResult signUp()
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
