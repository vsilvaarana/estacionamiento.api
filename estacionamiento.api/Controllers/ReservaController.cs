using estacionamiento.BusinessLogic;
using estacionamiento.Entities;
using Microsoft.AspNetCore.Mvc;

namespace estacionamiento.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : Controller
    {
        private readonly ReservaBL reservaBL;

        public ReservaController(ReservaBL _reservaBL)
        {
            reservaBL = _reservaBL;
        }
        [HttpPost]
        public IActionResult Registrar([FromBody] ReservaEntity reservaEntity)
        {
            try
            {
                return Ok(reservaBL.Registrar(reservaEntity));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Modificar([FromBody] ReservaEntity reservaEntity)
        {
            try
            {
                return Ok(reservaBL.Modificar(reservaEntity));
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
                return Ok(reservaBL.Eliminar(id));
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
                return Ok(reservaBL.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
