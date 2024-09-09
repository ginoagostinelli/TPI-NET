using Dominio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                context.Solicitudes.Remove(solitudToDelete);
                context.SaveChanges();
            }
        }
    }
}
