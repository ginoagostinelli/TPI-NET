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

    public class MaterialApiClient
    {
        private static HttpClient client = new HttpClient();
        static MaterialApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5189/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<Material> GetAsync(int id)
        {
            Material material = null;
            HttpResponseMessage response = await client.GetAsync("materiales/" + id);
            if (response.IsSuccessStatusCode)
            {
                material = await response.Content.ReadAsAsync<Material>();
            }
            return material;
        }

        public static async Task<IEnumerable<Material>> GetAllAsync()
        {
            IEnumerable<Material> material = null;
            HttpResponseMessage response = await client.GetAsync("materiales");
            if (response.IsSuccessStatusCode)
            {
                material = await response.Content.ReadAsAsync<IEnumerable<Material>>();
            }
            return material;
        }

        public static async Task<IEnumerable<Material>> GetVisitaAsync(int id)
        {
            IEnumerable<Material> material = null;
            HttpResponseMessage response = await client.GetAsync("listamateriales" + id);
            if (response.IsSuccessStatusCode)
            {
                material = await response.Content.ReadAsAsync<IEnumerable<Material>>();
            }
            return material;
        }

        public async static Task AddAsync(Material material)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("materiales", material);
            response.EnsureSuccessStatusCode();
        }

        public async static Task AddListaAsync(IEnumerable<Material> materiales)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("listamateriales", materiales);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("materiales/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Material material)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("materiales", material);
            response.EnsureSuccessStatusCode();
        }
    }
}
