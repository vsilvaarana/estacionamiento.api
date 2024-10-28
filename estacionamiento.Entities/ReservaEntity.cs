using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamiento.Entities
{
    public class ReservaEntity
    {
        public int reservaId { get; set; }
        public int usuarioId { get; set; }
        public int estacionamientoId { get; set; }
        public int vehiculoId { get; set; } = 0;
        public DateTime fecha { get; set; }
        public int tipo { get; set; }
        public int estado { get; set; }
   }
}
