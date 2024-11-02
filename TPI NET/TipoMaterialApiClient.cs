using Dominio.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WindowsForms
{
    //Revisar si no seria mejor usar metodos estaticos        

    public class TipoMaterialApiClient
    {
        private static HttpClient client = new HttpClient();
        static TipoMaterialApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5189/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<TipoMaterial> GetAsync(int id)
        {
            TipoMaterial tipoMaterial = null;
            HttpResponseMessage response = await client.GetAsync("tiposmateriales/" + id);
            if (response.IsSuccessStatusCode)
            {
                tipoMaterial = await response.Content.ReadAsAsync<TipoMaterial>();
            }
            return tipoMaterial;
        }

        public static async Task<IEnumerable<TipoMaterial>> GetAllAsync()
        {
            IEnumerable<TipoMaterial> tipoMaterial = null;
            HttpResponseMessage response = await client.GetAsync("tiposmateriales");
            if (response.IsSuccessStatusCode)
            {
                tipoMaterial = await response.Content.ReadAsAsync<IEnumerable<TipoMaterial>>();
            }
            return tipoMaterial;
        }

        public async static Task AddAsync(TipoMaterial tipoMaterial)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("tiposmateriales", tipoMaterial);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("tiposmateriales/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(TipoMaterial tipoMaterial)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("tiposmateriales", tipoMaterial);
            response.EnsureSuccessStatusCode();
        }
    }
}
