using Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Services
{
    public class MaterialService
    {
        public void Add(Material tipoMaterial)
        {
            using var context = new EmpresaContext();

            context.Materiales.Add(tipoMaterial);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new EmpresaContext();

            Material? materialToDelete = context.Materiales.Find(id);

            if (materialToDelete != null)
            {
                context.Materiales.Remove(materialToDelete);
                context.SaveChanges();
            }
        }

        public Material? Get(int id)
        {
            using var context = new EmpresaContext();

            return context.Materiales.Find(id);
        }

        public IEnumerable<Material> GetAll()
        {
            using var context = new EmpresaContext();

            return context.Materiales.ToList();
        }

        public void Update(Material material)
        {
            using var context = new EmpresaContext();

            Material? materialToUpdate = context.Materiales.Find(material.Id);

            if (material != null)
            {
                materialToUpdate.Cantidad = material.Cantidad;
                materialToUpdate.Tipo = material.Tipo;
                materialToUpdate.Visita = material.Visita;
                context.SaveChanges();
            }
        }
    }
}
