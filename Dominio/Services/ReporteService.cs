using Dominio;
using Dominio.Model;

namespace Domain.Services
{
    public class ReporteService
    {

        public IEnumerable<RepPorTipo> PorTipo()
        {
            using var context = new EmpresaContext();
            return (from s in context.Solicitudes
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

    }
}

