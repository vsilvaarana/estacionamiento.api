using estacionamiento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamiento.Repositories
{
    public interface UsuarioRepository
    {
        IEnumerable<UsuarioModel> ListarPorNombre(string nombre);
    }
}
