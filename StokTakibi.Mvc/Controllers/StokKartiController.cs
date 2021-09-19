using Microsoft.AspNetCore.Mvc;
using StokTakibi.Business.Abstract;
using StokTakibi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakibi.Mvc.Controllers
{
    public class StokKartiController : Controller
    {
        private readonly IStokKartiService _stokKartiService;

        public StokKartiController(IStokKartiService stokKartiService)
        {
            _stokKartiService = stokKartiService;
        }

        public IActionResult Index()
        {
            var result = _stokKartiService.GetAllByNonDeleted();

            if (result.Count > -1)
                return View(result);

            return NotFound();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StokKarti stokKarti)
        {
            _stokKartiService.Add(stokKarti);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var result = _stokKartiService.GetById(id);

            if (result is not null)
            {
                return View(result);

            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(StokKarti stokKarti)
        {
            _stokKartiService.Update(stokKarti);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if(id!=null)
            {
                _stokKartiService.Delete(id.Value);
                return RedirectToAction("Index");
            }
            return NotFound();

        }
    }
}
