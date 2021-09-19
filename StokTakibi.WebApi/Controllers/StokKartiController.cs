using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StokTakibi.Business.Abstract;
using StokTakibi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StokTakibi.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StokKartiController : ControllerBase
    {

        private readonly IStokKartiService _stokKartiService;

        public StokKartiController(IStokKartiService stokKartiService)
        {
            this._stokKartiService = stokKartiService;
        }

        [HttpPost]
        public IActionResult Add(StokKarti stokKarti)
        {
            _stokKartiService.Add(stokKarti);
            return CreatedAtAction(nameof(Get), new { id = stokKarti.Id }, stokKarti);
        }

        [HttpPut]
        public IActionResult Update(StokKarti stokKarti)
        {
            _stokKartiService.Update(stokKarti);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _stokKartiService.Delete(id);
            return Ok();
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_stokKartiService.GetAllByNonDeleted());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            var data = _stokKartiService.GetById(id);
            return Ok(data);
        }


    }
}
