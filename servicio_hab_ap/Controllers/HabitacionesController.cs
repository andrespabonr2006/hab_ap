using aplicaciones_hab_ap.entidades;
using aplicaciones_hab_ap.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace servicio_hab_ap.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HabitacionesController : ControllerBase
    {
        private IHabitacionesAplicacion IHabitacionesAplicacion;

        public HabitacionesController(IHabitacionesAplicacion IHabitacionesAplicacion)
        {
            this.IHabitacionesAplicacion = IHabitacionesAplicacion;
        }

        [HttpPost]
        public List<Habitaciones> Consultar()
        {
            return this.IHabitacionesAplicacion.Consultar();
        }

        [HttpPost]
        public List<Habitaciones> Buscar(Habitaciones entidad)
        {
            return this.IHabitacionesAplicacion.Buscar(entidad);
        }

        [HttpPost]
        public Habitaciones Insertar(Habitaciones entidad)
        {
            return this.IHabitacionesAplicacion.Insertar(entidad);
        }

        [HttpPost]
        public Habitaciones Actualizar(Habitaciones entidad)
        {
            return this.IHabitacionesAplicacion.Actualizar(entidad);
        }

        [HttpPost]
        public Habitaciones Borrar(Habitaciones entidad)
        {
            return this.IHabitacionesAplicacion.Borrar(entidad);
        }
    }
}
