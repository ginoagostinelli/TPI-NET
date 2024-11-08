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
        public void Add(Material material)
        {
            using var context = new EmpresaContext();

            context.Materiales.Add(material);
            context.SaveChanges();
        }

        public void AddLista(IEnumerable<Material> materiales)
        {
            int? id = null;
            using var context = new EmpresaContext();
            IEnumerable<Material> listaAlmacenada = null;
            Material auxiliar = null;

            
            //Chequea que todos los Id de Visita sean iguales, sino no hace nada.
            foreach (Material material in materiales)
            {
                if (id == null)
                {
                    id = material.Visita;

                }
                else
                {
                    if (id != material.Visita) return;
                }
            }

            if (id == null) return;//corregir porque sino nunca va a eliminar el ultimo elemento que quede en la lista(si la lista enviada no tiene elementos, id va a ser null

            //Primero busca uno por uno los materiales recibidos entre los guardados por Id, si no lo encuentra lo borra.
            listaAlmacenada = this.GetAllPorVisita((int) id);
            foreach (Material material in listaAlmacenada)
            {
                auxiliar = materiales.FirstOrDefault(m => m.Id == material.Id);
                if (auxiliar == null)
                {
                    this.Delete(material.Id);
                }
            }

            //Agrega los materiales con Id == 0
            foreach (Material material in materiales)
            {
                if(material.Id == 0)
                {
                    this.Add(material);
                }
            }

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

        public IEnumerable<Material> GetAllPorVisita(int visita)
        {
            using var context = new EmpresaContext();
            List<Material> listaSinFiltrar = context.Materiales.ToList();


            return from m in listaSinFiltrar where m.Visita == visita select m;// listaSinFiltrar.Where(m => m.Visita == visita);
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
