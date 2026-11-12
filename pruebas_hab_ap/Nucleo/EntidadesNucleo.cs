using aplicaciones_hab_ap.entidades;

namespace pruebas_hab_ap.Nucleo
{
    public class EntidadesNucleo
    {
        public static Usuarios? Usuarios()
        {
            var entidad = new Usuarios();
            entidad.Nombre = "U-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Contraseña = "1234";
            return entidad;
        }

        public static Habitaciones? Habitaciones()
        {
            var entidad = new Habitaciones();
            entidad.Codigo = "C-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre = "N-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Capacidad = 2;
            entidad.Personas = 1;
            entidad.Precio = 100;
            entidad.FechaEspecial = false;
            entidad.Usuario = 1;
            return entidad;
        }

        public static Auditorias? Auditorias()
        {
            var entidad = new Auditorias();
            entidad.Descripcion = "D-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Fecha = DateTime.Now;
            return entidad;
        }
    }
}
