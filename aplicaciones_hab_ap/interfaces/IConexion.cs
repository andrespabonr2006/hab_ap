using aplicaciones_hab_ap.entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace aplicaciones_hab_ap.interfaces
{
    public interface IConexion
    {
        DbSet<Usuarios>? Usuarios { get; set; }
        DbSet<Habitaciones>? Habitaciones { get; set; }
        DbSet<Auditorias>? Auditorias { get; set; }

        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
