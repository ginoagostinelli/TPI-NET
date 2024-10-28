using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model
{
    public class Material
    {
        public int Id { get; set; }
        public int Tipo {  get; set; }
        public int Visita{ get; set; }
        public string Cantidad { get; set; }
    }
}
