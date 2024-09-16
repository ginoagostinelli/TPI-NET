using Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Services
{
    public class TipoMaterialService
    {
        public void Add(TipoMaterial tipoMaterial)
        {
            using var context = new EmpresaContext();

            context.TiposMateriales.Add(tipoMaterial);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new EmpresaContext();

            TipoMaterial? tipoMaterialToDelete = context.TiposMateriales.Find(id);

            if (tipoMaterialToDelete != null)
            {
                context.TiposMateriales.Remove(tipoMaterialToDelete);
                context.SaveChanges();
            }
        }

        public TipoMaterial? Get(int id)
        {
            using var context = new EmpresaContext();

            return context.TiposMateriales.Find(id);
        }

        public IEnumerable<TipoMaterial> GetAll()
        {
            using var context = new EmpresaContext();

            return context.TiposMateriales.ToList();
        }

        public void Update(TipoMaterial tipoMaterial)
        {
            using var context = new EmpresaContext();

            TipoMaterial? tipoMaterialToUpdate = context.TiposMateriales.Find(tipoMaterial.Id);

            if (tipoMaterialToUpdate != null)
            {
                tipoMaterialToUpdate.Descripcion = tipoMaterial.Descripcion;
                context.SaveChanges();
            }
        }
    }
}
