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
        public TipoMaterial Tipo {  get; set; }
        public Visita Visita{ get; set; }
        public string Cantidad { get; set; }
    }
}
