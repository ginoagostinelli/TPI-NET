using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model
{
    public class Rol
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public bool ClientesVer { get; set; }
        public bool ClientesAgregar { get; set; }
        public bool ClientesModificar { get; set; }
        public bool ClientesEliminar { get; set; }
        public bool SolicitudesVer { get; set; }
        public bool SolicitudesAgregar { get; set; }
        public bool SolicitudesModificar { get; set; }
        public bool SolicitudesEliminar { get; set; }
        public bool VisitasVer { get; set; }
        public bool VisitasAgregar { get; set; }
        public bool VisitasModificar { get; set; }
        public bool VisitasEliminar { get; set; }
        public bool TecnicosVer { get; set; }
        public bool TecnicosAgregar { get; set; }
        public bool TecnicosModificar { get; set; }
        public bool TecnicosEliminar { get; set; }
        public bool TiposMaterialesVer { get; set; }
        public bool TiposMaterialesAgregar { get; set; }
        public bool TiposMaterialesModificar { get; set; }
        public bool TiposMaterialesEliminar { get; set; }
        public bool TiposSolicitudesVer { get; set; }
        public bool TiposSolicitudesAgregar { get; set; }
        public bool TiposSolicitudesModificar { get; set; }
        public bool TiposSolicitudesEliminar { get; set; }
    }
}
