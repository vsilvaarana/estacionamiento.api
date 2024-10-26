using estacionamiento.BusinessLogic;
using estacionamiento.Entities;
using Microsoft.AspNetCore.Mvc;

namespace estacionamiento.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly UsuarioBL usuarioBL;

        public UsuarioController(UsuarioBL _usuarioBL)
        {
            usuarioBL = _usuarioBL;
        }
        [HttpPost]
        public IActionResult Registrar([FromBody] UsuarioEntity usuarioEntity)
        {
            try
            {
                return Ok(usuarioBL.Registrar(usuarioEntity));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Modificar([FromBody] UsuarioEntity usuarioEntity)
        {
            try
            {
                return Ok(usuarioBL.Modificar(usuarioEntity));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Eliminar(int id)
        {
            try
            {
                return Ok(usuarioBL.Eliminar(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                return Ok(usuarioBL.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("ListarPorNombre")]
        public IActionResult ListarPorNombre(string nombre)
        {
            try
            {
                return Ok(usuarioBL.ListarPorNombre(nombre));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
