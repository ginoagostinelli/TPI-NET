﻿namespace Dominio.Model
{
    public class Tecnico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreMix => $"(ID: {Id}) {Apellido}, {Nombre}";
        public string Email { get; set; }
        public string Password { get; set; }

        public int Rol { get; set; }

        public string Telefono { get; set; }
    }
}
