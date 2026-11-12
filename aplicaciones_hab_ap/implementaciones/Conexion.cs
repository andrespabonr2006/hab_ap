using aplicaciones_hab_ap.entidades;
using aplicaciones_hab_ap.interfaces;
using aplicaciones_hab_ap.nucleo;
using Microsoft.EntityFrameworkCore;

namespace aplicaciones_hab_ap.implementaciones
{
    public class Conexion : DbContext, IConexion
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DatosGenerales.StringConexion()!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Usuarios>? Usuarios { get; set; }
        public DbSet<Habitaciones>? Habitaciones { get; set; }
        public DbSet<Auditorias>? Auditorias { get; set; }
    }
}
