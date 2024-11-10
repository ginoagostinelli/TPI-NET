using Dominio.Model;

namespace Dominio.Services
{
    public class SolicitudService
    {
        public void Add(Solicitud solicitud)
        {
            using var context = new EmpresaContext();

            context.Solicitudes.Add(solicitud);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new EmpresaContext();

            Solicitud? solicitudToDelete = context.Solicitudes.Find(id);

            if (solicitudToDelete != null)
            {
                context.Solicitudes.Remove(solicitudToDelete);
                context.SaveChanges();
            }
        }

        public Solicitud? Get(int id)
        {
            using var context = new EmpresaContext();

            return context.Solicitudes.Find(id);
        }

        public IEnumerable<Solicitud> GetAll()
        {
            using var context = new EmpresaContext();

            return context.Solicitudes.ToList();
        }

        public void Update(Solicitud solicitud)
        {
            using var context = new EmpresaContext();

            Solicitud? solicitudToUpdate = context.Solicitudes.Find(solicitud.Id);

            if (solicitudToUpdate != null)
            {
                solicitudToUpdate.Estado = solicitud.Estado;
                solicitudToUpdate.Motivo = solicitud.Motivo;
                solicitudToUpdate.Fecha = solicitud.Fecha;
                solicitudToUpdate.Conclusion = solicitud.Conclusion;
                solicitudToUpdate.Tipo = solicitud.Tipo;
                solicitudToUpdate.Cliente = solicitud.Cliente;

                context.SaveChanges();
            }
        }
    }
}
