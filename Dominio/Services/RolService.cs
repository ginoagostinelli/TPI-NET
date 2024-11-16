using Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Services
{
    public class RolService
    {
        public Rol Add(Rol rol)
        {
            
            using var context = new EmpresaContext();

            context.Roles.Add(rol);
            context.SaveChanges();

            return rol;

        }

        public void Delete(int id)
        {
            using var context = new EmpresaContext();

            Rol? rolToDelete = context.Roles.Find(id);

            if (rolToDelete != null)
            {
                context.Roles.Remove(rolToDelete);
                context.SaveChanges();
            }
        }

        public Rol? Get(int id)
        {
            using var context = new EmpresaContext();

            return context.Roles.Find(id);
        }
        public Rol? GetDescripcion(string descripcion)
        {
            using var context = new EmpresaContext();

            return context.Roles.FirstOrDefault(r => r.Descripcion == descripcion);
        }

        public IEnumerable<Rol> GetAll()
        {
            using var context = new EmpresaContext();

            return context.Roles.ToList();
        }

        public void Update(Rol rol)
        {
            using var context = new EmpresaContext();

            Rol? rolToUpdate = context.Roles.Find(rol.Id);

            if (rolToUpdate != null)
            {
                rolToUpdate.Descripcion = rol.Descripcion;
                rolToUpdate.ClientesVer = rol.ClientesVer;
                rolToUpdate.ClientesModificar = rol.ClientesModificar;
                rolToUpdate.ClientesEliminar = rol.ClientesEliminar;
                rolToUpdate.SolicitudesVer = rol.SolicitudesVer;
                rolToUpdate.SolicitudesModificar = rol.SolicitudesModificar;
                rolToUpdate.SolicitudesEliminar = rol.SolicitudesEliminar;
                rolToUpdate.VisitasVer = rol.VisitasVer;
                rolToUpdate.VisitasModificar = rol.VisitasModificar;
                rolToUpdate.VisitasEliminar = rol.VisitasEliminar;
                rolToUpdate.TecnicosVer = rol.TecnicosVer;
                rolToUpdate.TecnicosModificar = rol.TecnicosModificar;
                rolToUpdate.TecnicosEliminar = rol.TecnicosEliminar;
                rolToUpdate.TiposMaterialesVer = rol.TiposMaterialesVer;
                rolToUpdate.TiposMaterialesModificar = rol.TiposMaterialesModificar;
                rolToUpdate.TiposMaterialesEliminar = rol.TiposMaterialesEliminar;
                rolToUpdate.TiposSolicitudesVer = rol.TiposSolicitudesVer;
                rolToUpdate.TiposSolicitudesModificar = rol.TiposSolicitudesModificar;
                rolToUpdate.TiposSolicitudesEliminar = rol.TiposSolicitudesEliminar;
                context.SaveChanges();
            }
        }
    }
}
