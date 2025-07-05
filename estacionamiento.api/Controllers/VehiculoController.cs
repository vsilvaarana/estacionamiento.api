using estacionamiento.BusinessLogic;
using estacionamiento.Entities;
using Microsoft.AspNetCore.Mvc;

namespace estacionamiento.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : Controller
    {
        private readonly VehiculoBL vehiculoBL;

        public VehiculoController(VehiculoBL _vehiculoBL)
        {
            vehiculoBL = _vehiculoBL;
        }
        [HttpPost]
        public IActionResult Registrar([FromBody] VehiculoEntity vehiculoEntity)
        {
            try
            {
                return Ok(vehiculoBL.Registrar(vehiculoEntity));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Modificar([FromBody] VehiculoEntity vehiculoEntity)
        {
            try
            {
                return Ok(vehiculoBL.Modificar(vehiculoEntity));
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
                return Ok(vehiculoBL.Eliminar(id));
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
                return Ok(vehiculoBL.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("ListarPorNombre")]
        public IActionResult ListarPorNombre(string placa = "0", int usuarioId = 0)
        {
            try
            {
                return Ok(vehiculoBL.ListarPorNombre(placa, usuarioId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
