using aplicaciones_hab_ap.entidades;

namespace aplicaciones_hab_ap.interfaces
{
    public interface IHabitacionesPresentacion
    {
        Habitaciones Insertar(Habitaciones entidad);
        Habitaciones Actualizar(Habitaciones entidad);
        List<Habitaciones> Consultar();
        List<Habitaciones> Buscar(Habitaciones entidad);
        Habitaciones Borrar(Habitaciones entidad);
    }
}
