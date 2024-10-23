using estacionamiento.Models;

namespace estacionamiento.Repositories
{
    public interface EstacionamientoRepository
    {
        IEnumerable<EstacionamientoModel> ListarPorId(string estacionamientoId);
    }
}
