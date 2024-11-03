﻿using System;
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

        public DateTime Fecha { get; set; }
        public int Tecnico {  get; set; }
        public int Solicitud {  get; set; }
    }
}
