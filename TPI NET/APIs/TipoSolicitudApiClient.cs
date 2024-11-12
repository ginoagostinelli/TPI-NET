using Dominio.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace TPI_NET.APIs
{

    public class TipoSolicitudApiClient
    {
        private static HttpClient client = new HttpClient();
        static TipoSolicitudApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5189/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<TipoSolicitud> GetAsync(int id)
        {
            TipoSolicitud tipoSolicitud = null;
            HttpResponseMessage response = await client.GetAsync("tipoSolicitudes/" + id);
            if (response.IsSuccessStatusCode)
            {
                tipoSolicitud = await response.Content.ReadAsAsync<TipoSolicitud>();
            }
            return tipoSolicitud;
        }

        public static async Task<IEnumerable<TipoSolicitud>> GetAllAsync()
        {
            IEnumerable<TipoSolicitud> tipoSolicitudes = null;
            HttpResponseMessage response = await client.GetAsync("tipoSolicitudes");
            if (response.IsSuccessStatusCode)
            {
                tipoSolicitudes = await response.Content.ReadAsAsync<IEnumerable<TipoSolicitud>>();
            }
            return tipoSolicitudes;
        }

        public async static Task AddAsync(TipoSolicitud tipoSolicitud)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("tipoSolicitudes", tipoSolicitud);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("tipoSolicitudes/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(TipoSolicitud tipoSolicitud)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("tipoSolicitudes", tipoSolicitud);
            response.EnsureSuccessStatusCode();
        }
    }
}
