using Dominio.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace TPI_NET.APIs
{

    public class SolicitudApiClient
    {
        private static HttpClient client = new HttpClient();
        static SolicitudApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5189/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<Solicitud> GetAsync(int id)
        {
            Solicitud solicitud = null;
            HttpResponseMessage response = await client.GetAsync("solicitudes/" + id);
            if (response.IsSuccessStatusCode)
            {
                solicitud = await response.Content.ReadAsAsync<Solicitud>();
            }
            return solicitud;
        }

        public static async Task<IEnumerable<Solicitud>> GetAllAsync()
        {
            IEnumerable<Solicitud> solicitud = null;
            HttpResponseMessage response = await client.GetAsync("solicitudes");
            if (response.IsSuccessStatusCode)
            {
                solicitud = await response.Content.ReadAsAsync<IEnumerable<Solicitud>>();
            }
            return solicitud;
        }

        public static async Task<Solicitud> AddAsync(Solicitud solicitud)
        {
            Solicitud solicitudSalida = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("solicitudes", solicitud);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                solicitud = await response.Content.ReadAsAsync<Solicitud>();
            }

            return solicitudSalida;
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("solicitudes/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Solicitud solicitud)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("solicitudes", solicitud);
            response.EnsureSuccessStatusCode();
        }
    }
}
