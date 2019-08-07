using Microsoft.AspNetCore.Mvc;
using RestAPIBlog.Models;
using RestAPIBlog.Services;

namespace RestAPIBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtigoController : ControllerBase
    {

        private IArtigoService _artigoService;

        public ArtigoController(IArtigoService artigoService)
        {
            _artigoService = artigoService;
        }

        // GET: api/Artigo
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_artigoService.FindAll());
        }

        // GET: api/Artigo/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var artigo = _artigoService.FindById(id);
            if (artigo == null) return NotFound();
            return Ok(artigo);
        }

        // POST: api/Artigo
        [HttpPost]
        public IActionResult Post([FromBody] Artigo artigo)
        {
            if (artigo == null) return BadRequest();
            return new ObjectResult(_artigoService.Create(artigo));
        }

        // PUT: api/Artigo/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Artigo artigo)
        {
            if (artigo == null) return BadRequest();
            return new ObjectResult(_artigoService.Update(artigo));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _artigoService.Delete(id);
            return NoContent();
        }
    }
}
