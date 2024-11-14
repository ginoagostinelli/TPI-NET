using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dominio.Model;


namespace Dominio.Services
{
    public class TipoSolicitudService
    {
        private readonly string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=ClienteDb";

        public void Add(TipoSolicitud tipoSolicitud)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "INSERT INTO TiposSolicitudes (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)";

            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Nombre", tipoSolicitud.Nombre);
            command.Parameters.AddWithValue("@Descripcion", tipoSolicitud.Descripcion);

            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "DELETE FROM TiposSolicitudes WHERE Id = @Id";

            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        public TipoSolicitud? Get(int id)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "SELECT Id, Nombre, Descripcion FROM TiposSolicitudes WHERE Id = @Id";

            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new TipoSolicitud
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Descripcion = reader.GetString(2)
                };
            }

            return null;
        }

        public IEnumerable<TipoSolicitud> GetAll()
        {
            List<TipoSolicitud> tiposSolicitudes = new List<TipoSolicitud>();

            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "SELECT Id, Nombre, Descripcion FROM TiposSolicitudes";

            using SqlCommand command = new SqlCommand(query, connection);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                TipoSolicitud tipoSolicitud = new TipoSolicitud
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Descripcion = reader.GetString(2)
                };

                tiposSolicitudes.Add(tipoSolicitud);
            }

            return tiposSolicitudes;
        }

        public void Update(TipoSolicitud tipoSolicitud)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "UPDATE TiposSolicitudes SET Nombre = @Nombre, Descripcion = @Descripcion WHERE Id = @Id";

            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", tipoSolicitud.Id);
            command.Parameters.AddWithValue("@Nombre", tipoSolicitud.Nombre);
            command.Parameters.AddWithValue("@Descripcion", tipoSolicitud.Descripcion);

            command.ExecuteNonQuery();
        }
    }
}
