using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model
{
    public class Solicitud
    {
        public int Id { get; set; }

        public string Estado { get; set; }
        public string Motivo {  get; set; }
        public DateTime Fecha { get; set; }
        public string Conclusion { get; set; }
        public int Tipo {  get; set; }
        public int Cliente {  get; set; }
    }
}
