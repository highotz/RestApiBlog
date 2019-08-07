using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPIBlog.Models;
using RestAPIBlog.Services;

namespace RestAPIBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComentarioController : ControllerBase
    {

        private IComentarioService _comentarioService;

        public ComentarioController(IComentarioService comentarioService)
        {
            _comentarioService = comentarioService;
        }


        // GET: api/Comentario
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_comentarioService.FindAll());
        }

        // GET: api/Comentario/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var comentario = _comentarioService.FindById(id);
            if (comentario == null) return NotFound();
            return Ok(comentario);
        }

        // POST: api/Comentario
        [HttpPost]
        public IActionResult Post([FromBody] Comentario comentario)
        {
            if (comentario == null) return BadRequest();
            return new ObjectResult(_comentarioService.Create(comentario));
        }

        // PUT: api/Comentario/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Comentario comentario)
        {
            if (comentario == null) return BadRequest();
            return new ObjectResult(_comentarioService.Update(comentario));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _comentarioService.Delete(id);
            return NoContent();
        }
    }
}
