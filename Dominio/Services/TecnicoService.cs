using Dominio;
using Dominio.Model;

namespace Domain.Services
{
    public class TecnicoService
    {
        public void Add(Tecnico tecnico)
        {
            using var context = new EmpresaContext();

            context.Tecnicos.Add(tecnico);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new EmpresaContext();

                Tecnico? tecnicoToDelete = context.Tecnicos.Find(id);

            if (tecnicoToDelete != null)
            {
                context.Tecnicos.Remove(tecnicoToDelete);
                context.SaveChanges();
            }
        }

        public Tecnico? Get(int id)
        {
            using var context = new EmpresaContext();

            return context.Tecnicos.Find(id);
        }

        public IEnumerable<Tecnico> GetAll()
        {
            using var context = new EmpresaContext();

            return context.Tecnicos.ToList();
        }

        public void Update(Tecnico tecnico)
        {
            using var context = new EmpresaContext();

            Tecnico? tecnicoToUpdate = context.Tecnicos.Find(tecnico.Id);

            if (tecnicoToUpdate != null)
            {
                tecnicoToUpdate.Nombre = tecnico.Nombre;
                tecnicoToUpdate.Apellido = tecnico.Apellido;
                tecnicoToUpdate.Email = tecnico.Email;
                tecnicoToUpdate.Password = tecnico.Password;
                tecnicoToUpdate.Rol = tecnico.Rol;
                tecnicoToUpdate.Telefono = tecnico.Telefono;
                context.SaveChanges();
            }
        }
    }
}

