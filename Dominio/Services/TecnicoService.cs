using Dominio;
using Dominio.Model;
using System.Text.RegularExpressions;

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

        public Tecnico? GetMail(string email)
        {
            using var context = new EmpresaContext();

            return context.Tecnicos.FirstOrDefault(t => t.Email == email);
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

        private void ValidarTecnico(Tecnico tecnico)
        {
            if (tecnico.Password.Length < 6)
            {
                throw new ArgumentException("La contraseña debe tener al menos 6 caracteres.");
            }

            if (!Regex.IsMatch(tecnico.Password, @"[A-Z]")) // Al menos una letra mayúscula
            {
                throw new ArgumentException("La contraseña debe incluir al menos una letra mayúscula.");
            }

            if (!Regex.IsMatch(tecnico.Password, @"[a-z]")) // Al menos una letra minúscula
            {
                throw new ArgumentException("La contraseña debe incluir al menos una letra minúscula.");
            }

            if (!Regex.IsMatch(tecnico.Password, @"\d")) // Al menos un número
            {
                throw new ArgumentException("La contraseña debe incluir al menos un número.");
            }

            if (string.IsNullOrEmpty(tecnico.Email) || !Regex.IsMatch(tecnico.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new ArgumentException("El email proporcionado no tiene un formato válido.");
            }
        }
    }
}

