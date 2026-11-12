using System.ComponentModel.DataAnnotations.Schema;

namespace aplicaciones_hab_ap.entidades
{
    public class Habitaciones
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public int Capacidad { get; set; }
        public int Personas { get; set; }
        public decimal Precio { get; set; }
        public bool FechaEspecial { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public int Usuario { get; set; }

        [ForeignKey("Usuario")] public Usuarios? _Usuario { get; set; }
    }
}
