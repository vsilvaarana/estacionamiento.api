namespace estacionamiento.Entities
{
    public class EstacionamientoEntity
    {
        public int estacionamientoId { get; set; }
        public string piso { get; set; } = string.Empty;
        public string espacio { get; set; } = string.Empty;        
        public int tipo { get; set; } = 0;
        public int estado { get; set; } = 0;
    }
}
