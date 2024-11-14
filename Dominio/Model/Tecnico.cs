namespace Dominio.Model
{
    public class Tecnico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreMix { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Rol { get; set; }

        public string Telefono { get; set; }
    }
}
