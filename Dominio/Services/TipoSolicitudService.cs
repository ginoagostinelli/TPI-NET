using Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Services
{
    public class TipoSolicitudService
    {
        public void Add(TipoSolicitud tipoSolicitud)
        {
            using var context = new EmpresaContext();

            context.TiposSolicitudes.Add(tipoSolicitud);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new EmpresaContext();

            TipoSolicitud? tipoSolicitudToDelete = context.TiposSolicitudes.Find(id);

            if (tipoSolicitudToDelete != null)
            {
                context.TiposSolicitudes.Remove(tipoSolicitudToDelete);
                context.SaveChanges();
            }
        }

        public TipoSolicitud? Get(int id)
        {
            using var context = new EmpresaContext();

            return context.TiposSolicitudes.Find(id);
        }

        public IEnumerable<TipoSolicitud> GetAll()
        {
            using var context = new EmpresaContext();

            return context.TiposSolicitudes.ToList();
        }

        public void Update(TipoSolicitud tipoSolicitud)
        {
            using var context = new EmpresaContext();

            TipoSolicitud? tipoSolicitudToUpdate = context.TiposSolicitudes.Find(tipoSolicitud.Id);

            if (tipoSolicitudToUpdate != null)
            {
                tipoSolicitudToUpdate.Descripcion = tipoSolicitud.Descripcion;
                context.SaveChanges();
            }
        }
    }
}
