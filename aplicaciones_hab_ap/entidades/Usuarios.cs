using System.ComponentModel.DataAnnotations.Schema;

namespace aplicaciones_hab_ap.entidades
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Contraseña { get; set; }

        [NotMapped] public List<Habitaciones>? Habitaciones { get; set; }
    }
}
