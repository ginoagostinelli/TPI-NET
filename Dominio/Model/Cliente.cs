using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Razon_Social { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public string Conclusion { get; set; }
    }
}
