using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamiento.Entities
{
    public class UsuarioEntity
    {
        public int usuarioId { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string apellido { get; set; } = string.Empty;
        public int tipodocumento { get; set; } = 0;
        public string documento { get; set; } = string.Empty;
        public string correo { get; set; } = string.Empty;
        public string contrasena { get; set; } = string.Empty;
        public string modelo { get; set; } = string.Empty;
        public string placa { get; set; } = string.Empty;

    }
}
