using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model
{
    public class RepPorTipo
    {
        public string Nombre { get; set; }
        public int Total { get; set; }
    }

    public class RepSolicitudesPorCliente
    {
        public string Cliente { get; set; }
        public int Total { get; set; }
    }

    public class FechasReporte
    {
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
    }
}
