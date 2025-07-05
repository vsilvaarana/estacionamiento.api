using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamiento.Entities
{
    public class VehiculoEntity
    {
        public int vehiculoId { get; set; }
        public int usuarioId { get; set; }
        public string modelo { get; set; } = string.Empty;
        public string marca { get; set; } = string.Empty;
        public string placa { get; set; } = string.Empty;
    }
}
