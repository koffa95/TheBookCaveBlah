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
    public class MyCaveController : Controller
    {
        public MyCaveController()
        {

        }
        public IActionResult signIn()
        {
            return View();
        }
    }
}
