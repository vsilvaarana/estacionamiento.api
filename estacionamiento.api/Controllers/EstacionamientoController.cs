using estacionamiento.BusinessLogic;
using estacionamiento.Entities;
using Microsoft.AspNetCore.Mvc;

namespace estacionamiento.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstacionamientoController : ControllerBase
    {
        private readonly EstacionamientoBL estacionamientoBL;
        
        public EstacionamientoController(EstacionamientoBL _estacionamientoBL)
        {
            estacionamientoBL = _estacionamientoBL;
        }
        [HttpGet]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                return Ok(estacionamientoBL.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ListarPorPiso")]
        public IActionResult ListarPorPiso(string piso)
        {
            try
            {
                return Ok(estacionamientoBL.ListarPorPiso(piso));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Registrar([FromBody] EstacionamientoEntity estacionamientoEntity)
        {
            try
            {
                return Ok(estacionamientoBL.Registrar(estacionamientoEntity));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Modificar([FromBody] EstacionamientoEntity estacionamientoEntity)
        {
            try
            {
                return Ok(estacionamientoBL.Modificar(estacionamientoEntity));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Eliminar(int estacionamientoId)
        {
            try
            {
                return Ok(estacionamientoBL.Eliminar(estacionamientoId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
