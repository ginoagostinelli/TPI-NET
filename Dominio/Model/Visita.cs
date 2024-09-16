using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model
{
    public class Visita
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public bool DebeVolver { get; set; }

        public DateOnly Fecha { get; set; }
        public Tecnico Tecnico {  get; set; }
        public Solicitud Solicitud {  get; set; }
    }
}
