using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamiento.Models
{
    public class ReservaModel
    {
        public int reservaId { get; set; }
        public string placa { get; set; } = string.Empty;
        public string espacio { get; set; } = string.Empty;
        public string piso { get; set; } = string.Empty;
        public string modelo { get; set; } = string.Empty;
        public DateTime fecha { get; set; }
        public int estado { get; set; }
    }
}
