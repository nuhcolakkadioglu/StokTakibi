using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakibi.Mvc.Controllers
{
    public class StokHareketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
