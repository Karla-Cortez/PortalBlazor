using PortalEstudiantil.AppBlazor.Models;
using System.Net.Http;
using System.Text.Json;

namespace PortalEstudiantil.AppBlazor.Services
{
    public class GradoService : IGradoService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient client;
        public GradoService(HttpClient httpClient)
        {
            client = httpClient;
        }

        public async Task<IEnumerable<Grado>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await client.GetStringAsync($"Grado");
            return JsonSerializer.Deserialize<IEnumerable<Grado>>(resp, options);
        }
    }
}
