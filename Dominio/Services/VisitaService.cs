using Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Services
{
    public class VisitaService
    {
        public Visita Add(Visita visita)
        {
            
            using var context = new EmpresaContext();

            context.Visitas.Add(visita);
            context.SaveChanges();

            return visita;

        }

        public void Delete(int id)
        {
            using var context = new EmpresaContext();

            Visita? visitaToDelete = context.Visitas.Find(id);

            if (visitaToDelete != null)
            {
                context.Visitas.Remove(visitaToDelete);
                context.SaveChanges();
            }
        }

        public Visita? Get(int id)
        {
            using var context = new EmpresaContext();

            return context.Visitas.Find(id);
        }

        public IEnumerable<Visita> GetAll()
        {
            using var context = new EmpresaContext();

            return context.Visitas.ToList();
        }

        public void Update(Visita visita)
        {
            using var context = new EmpresaContext();

            Visita? visitaToUpdate = context.Visitas.Find(visita.Id);

            if (visitaToUpdate != null)
            {
                visitaToUpdate.Descripcion = visita.Descripcion;
                visitaToUpdate.DebeVolver = visita.DebeVolver;
                visitaToUpdate.Fecha = visita.Fecha;
                visitaToUpdate.Solicitud = visita.Solicitud;
                visitaToUpdate.Tecnico = visita.Tecnico;
                context.SaveChanges();
            }
        }
    }
}
