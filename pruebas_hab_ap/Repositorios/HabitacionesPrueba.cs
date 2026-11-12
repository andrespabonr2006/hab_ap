using aplicaciones_hab_ap.entidades;
using aplicaciones_hab_ap.implementaciones;
using aplicaciones_hab_ap.interfaces;
using Microsoft.EntityFrameworkCore;
using pruebas_hab_ap.Nucleo;

namespace pruebas_hab_ap.Repositorios
{
    [TestClass]
    public class HabitacionesPrueba
    {
        private readonly IConexion? iConexion;
        private List<Habitaciones>? lista;
        private Habitaciones? entidad;

        public HabitacionesPrueba()
        {
            iConexion = new Conexion();
        }

        [TestMethod]
        public void Ejecutar()
        {
            Assert.IsTrue(Guardar());
            Assert.IsTrue(Modificar());
            Assert.IsTrue(Listar());
            Assert.IsTrue(Borrar());
        }

        public bool Listar()
        {
            this.lista = this.iConexion!.Habitaciones!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            this.entidad = EntidadesNucleo.Habitaciones()!;

            this.iConexion!.Habitaciones!.Add(this.entidad);
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Nombre = "Test";

            var entry = this.iConexion!.Entry<Habitaciones>(this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Borrar()
        {
            this.iConexion!.Habitaciones!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }
}
