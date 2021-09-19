using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StokTakibi.Business.Abstract;
using StokTakibi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
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

        public async Task<IActionResult> Index()
        {
            var stokKartlari = new List<StokKarti>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:10077/api/stokkarti/"))
                {
                    string data = await response.Content.ReadAsStringAsync();
                    stokKartlari = JsonConvert.DeserializeObject<List<StokKarti>>(data);
                }
            }
            return View(stokKartlari);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(StokKarti stokKarti)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("http://localhost:10077/api/stokkarti/", stokKarti);
            response.EnsureSuccessStatusCode();
            //_stokKartiService.Add(stokKarti);
            if (response.StatusCode == System.Net.HttpStatusCode.Created)

                return RedirectToAction("Index");

            else

                return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            var stokKartlari = new StokKarti();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:10077/api/stokkarti/" + id))
                {
                    string data = await response.Content.ReadAsStringAsync();
                    stokKartlari = JsonConvert.DeserializeObject<StokKarti>(data);
                }
            }
            return View(stokKartlari);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(StokKarti stokKarti)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.PutAsJsonAsync("http://localhost:10077/api/stokkarti/", stokKarti);
            response.EnsureSuccessStatusCode();
            //_stokKartiService.Add(stokKarti);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)

                return RedirectToAction("Index");

            else

                return View();

        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.DeleteAsync("http://localhost:10077/api/stokkarti/" + id);

            return RedirectToAction("Index");


        }
    }
}
