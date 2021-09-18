using Microsoft.AspNetCore.Mvc;
using StokTakibi.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakibi.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStokKartiService _stokKartiService;
        public HomeController(IStokKartiService stokKartiService)
        {
            _stokKartiService = stokKartiService;
        }
        public IActionResult Index()
        {
            return View(_stokKartiService.GetAll());
        }
    }
}
