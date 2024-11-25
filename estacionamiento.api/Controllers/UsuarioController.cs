using estacionamiento.BusinessLogic;
using estacionamiento.Entities;
using estacionamiento.Entities.Models;
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

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            try
            {
                var usuario = usuarioBL.ValidarCredenciales(model.Email, model.Password);

                if (usuario == null)
                {
                    return Unauthorized(new { Message = "Credenciales inválidas." });
                }

                var token = "user";

                return Ok(new { Token = token, Success = true, Name = usuario.nombre+" "+usuario.apellido });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Ocurrió un error interno.", Error = ex.Message });
            }
        }

    }
}
