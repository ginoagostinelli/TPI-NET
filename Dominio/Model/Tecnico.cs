using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model
{
    public class Tecnico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public string Rol { get; set; }

        public string Telefono { get; set; }
    }
}
