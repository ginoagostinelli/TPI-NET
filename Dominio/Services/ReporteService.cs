﻿using Dominio;
using Dominio.Model;

namespace Domain.Services
{
    public class ReporteService
    {

        public IEnumerable<RepPorTipo> PorTipo()
        {
            using var context = new EmpresaContext();
            return (from s in context.Solicitudes
                    

            /*where docs.AttachId != null*/

                    group s by s.Tipo into g
                    where g.Count() > 0
                    select new RepPorTipo { Nombre = context.TiposSolicitudes.First(t => t.Id == g.Key).Nombre, Total = g.Count() }).ToList();

           
        }

        public IEnumerable<RepSolicitudesPorCliente> PorCliente(FechasReporte periodo)
        {
            using var context = new EmpresaContext();
            return (from s in context.Solicitudes
                    where s.Fecha >= periodo.Desde
                    && s.Fecha <= periodo.Hasta
                    group s by s.Cliente into g
                    where g.Count() > 0
                    select new RepSolicitudesPorCliente { Cliente = context.Clientes.First(c => c.Id == g.Key).NombreMix, Total = g.Count() }).ToList();
        }

        /*public void Add(Cliente cliente)
        {
            using var context = new EmpresaContext();

            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new EmpresaContext();

            Cliente? clienteToDelete = context.Clientes.Find(id);

            if (clienteToDelete != null)
            {
                context.Clientes.Remove(clienteToDelete);
                context.SaveChanges();
            }
        }

        public Cliente? Get(int id)
        {
            using var context = new EmpresaContext();

            return context.Clientes.Find(id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            using var context = new EmpresaContext();

            return context.Clientes.ToList();
        }

        public void Update(Cliente cliente)
        {
            using var context = new EmpresaContext();

            Cliente? clienteToUpdate = context.Clientes.Find(cliente.Id);

            if (clienteToUpdate != null)
            {
                clienteToUpdate.Nombre = cliente.Nombre;
                clienteToUpdate.Apellido = cliente.Nombre;
                clienteToUpdate.RazonSocial = cliente.RazonSocial;
                clienteToUpdate.Direccion = cliente.Direccion;
                clienteToUpdate.Telefono = cliente.Telefono;
              
                context.SaveChanges();
            }
        }*/

    }
}

