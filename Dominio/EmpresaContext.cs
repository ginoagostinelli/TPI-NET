using Dominio.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Entity;

namespace Dominio
{
    internal class EmpresaContext : DbContext
    {
        internal DbSet<Cliente> Clientes { get; set; }
        internal DbSet<Tecnico> Tecnicos { get; set; }
        internal DbSet<Solicitud> Solicitudes { get; set; }
        internal DbSet<Visita> Visitas { get; set; }
        internal DbSet<Material> Materiales { get; set; }
        internal DbSet<TipoSolicitud> TiposSolicitudes { get; set; }
        internal DbSet<TipoMaterial> TiposMateriales { get; set; }

        internal EmpresaContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=ClienteDb");
    }
}
