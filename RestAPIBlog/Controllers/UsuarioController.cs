using Microsoft.AspNetCore.Mvc;
using RestAPIBlog.Models;
using RestAPIBlog.Services;

namespace RestAPIBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET: api/Usuario
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuarioService.FindAll());
        }

        // GET: api/Usuario/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var usuario = _usuarioService.FindById(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }

        // POST: api/Usuario
        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            if (usuario == null) return BadRequest();
            return new ObjectResult(_usuarioService.Create(usuario));
        }

        // PUT: api/Usuario/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Usuario usuario)
        {
            if (usuario == null) return BadRequest();
            return new ObjectResult(_usuarioService.Update(usuario));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            _usuarioService.Delete(id);
            return NoContent();
        }
    }
}
