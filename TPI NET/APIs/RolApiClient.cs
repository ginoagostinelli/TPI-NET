using Dominio.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace TPI_NET.APIs
{
    //Revisar si no seria mejor usar metodos estaticos        

    public class RolApiClient
    {
        private static HttpClient client = new HttpClient();
        static RolApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5189/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<Rol> GetDescripcionAsync(string rol)
        {
            Rol rolObtenido = null;
            HttpResponseMessage response = await client.GetAsync("roles/" + rol);
            if (response.IsSuccessStatusCode)
            {
                rolObtenido = await response.Content.ReadAsAsync<Rol>();
            }
            return rolObtenido;
        }

    }
}
