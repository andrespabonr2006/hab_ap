using aplicaciones_hab_ap.entidades;
using Microsoft.EntityFrameworkCore;

namespace aplicaciones_hab_ap.interfaces
{
    public class HabitacionesAplicacion : IHabitacionesAplicacion
    {
        private IConexion IConexion;

        public HabitacionesAplicacion(IConexion IConexion)
        {
            this.IConexion = IConexion;
        }

        public Habitaciones Actualizar(Habitaciones entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            ValidarRelaciones(entidad);
            Reglas(entidad);

            var entry = this.IConexion!.Entry<Habitaciones>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion!.SaveChanges();
            return entidad;
        }

        public Habitaciones Borrar(Habitaciones entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            this.IConexion.Habitaciones!.Remove(entidad!);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Habitaciones> Buscar(Habitaciones entidad)
        {
            return this.IConexion.Habitaciones!
                .Where(x => x.Nombre!.Contains(entidad.Nombre!))
                .ToList();
        }

        public List<Habitaciones> Consultar()
        {
            return this.IConexion.Habitaciones!.Take(5).ToList();
        }

        public Habitaciones Insertar(Habitaciones entidad)
        {
            if (entidad.Id != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            ValidarRelaciones(entidad);
            Reglas(entidad);

            this.IConexion.Habitaciones!.Add(entidad!);
            this.IConexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Habitaciones entidad)
        {
            return string.IsNullOrEmpty(entidad.Codigo) ||
                string.IsNullOrEmpty(entidad.Nombre) ||
                entidad.Capacidad <= 0 ||
                entidad.Personas <= 0 ||
                entidad.Usuario <= 0;
        }

        private void ValidarRelaciones(Habitaciones entidad)
        {
            if (!this.IConexion.Usuarios!.Any(x => x.Id == entidad.Usuario))
                throw new Exception("No existe Usuario con Id " + entidad.Usuario);
        }

        private void Reglas(Habitaciones entidad)
        {
            // Regla 1: no superar el numero de personas por habitacion
            if (entidad.Personas > entidad.Capacidad)
                throw new Exception("Supera el numero de personas de la habitacion");

            // Reglas 2 y 3: descuentos
            decimal porcentaje = 0;
            if (entidad.FechaEspecial)
            {
                if (entidad.Precio > 150)
                    porcentaje = 0.05m;      // fechas especiales: solo 5%
            }
            else if (entidad.Precio > 300)
                porcentaje = 0.18m;          // compras superiores a $300
            else if (entidad.Precio > 150)
                porcentaje = 0.13m;          // compras superiores a $150

            entidad.Descuento = entidad.Precio * porcentaje;
            entidad.Total = entidad.Precio - entidad.Descuento;
        }
    }
}
