using estacionamiento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamiento.Repositories
{
    public interface ReservaRepository
    {
        IEnumerable<ReservaModel> ListarPorUsuario(int empleadoId, string fechaInicio, string fechaFin, string tipo);
    }
}
