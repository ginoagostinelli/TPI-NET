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

    public class TecnicoApiClient
    {
        private static HttpClient client = new HttpClient();
        static TecnicoApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5189/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<Tecnico> GetAsync(int id)
        {
            Tecnico tecnico = null;
            HttpResponseMessage response = await client.GetAsync("tecnicos/" + id);
            if (response.IsSuccessStatusCode)
            {
                tecnico = await response.Content.ReadAsAsync<Tecnico>();
            }
            return tecnico;
        }

        public static async Task<IEnumerable<Tecnico>> GetAllAsync()
        {
            IEnumerable<Tecnico> tecnicos = null;
            HttpResponseMessage response = await client.GetAsync("tecnicos");
            if (response.IsSuccessStatusCode)
            {
                tecnicos = await response.Content.ReadAsAsync<IEnumerable<Tecnico>>();
            }
            return tecnicos;
        }

        public async static Task AddAsync(Tecnico tecnico)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("tecnicos", tecnico);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("tecnicos/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Tecnico tecnico)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("tecnicos", tecnico);
            response.EnsureSuccessStatusCode();
        }
    }
}
