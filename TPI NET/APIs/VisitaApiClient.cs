using Dominio.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace TPI_NET.APIs
{  

    public class VisitaApiClient
    {
        private static HttpClient client = new HttpClient();
        static VisitaApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5189/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<Visita> GetAsync(int id)
        {
            Visita visita = null;
            HttpResponseMessage response = await client.GetAsync("visitas/" + id);
            if (response.IsSuccessStatusCode)
            {
                visita = await response.Content.ReadAsAsync<Visita>();
            }
            return visita;
        }

        public static async Task<IEnumerable<Visita>> GetAllAsync()
        {
            IEnumerable<Visita> visita = null;
            HttpResponseMessage response = await client.GetAsync("visitas");
            if (response.IsSuccessStatusCode)
            {
                visita = await response.Content.ReadAsAsync<IEnumerable<Visita>>();
            }
            return visita;
        }

        public static async Task<Visita> AddAsync(Visita visita)
        {
            Visita visitaSalida = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("visitas", visita);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                visitaSalida = await response.Content.ReadAsAsync<Visita>();
            }

            return visitaSalida;
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("visitas/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Visita visita)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("visitas", visita);
            response.EnsureSuccessStatusCode();
        }
    }
}
