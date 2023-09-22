using PortalEstudiantil.AppBlazor.Models;
using System.Net.Http;
using System.Text.Json;

namespace PortalEstudiantil.AppBlazor.Services
{
    public class DocenteService : IDocenteService
    {
            //inyección de dependencias de HttpClient
        private readonly HttpClient client;
        public DocenteService(HttpClient httpClient)
        {
            client = httpClient;
        }

        public async Task<IEnumerable<Docente>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await client.GetStringAsync($"Docente");
            return JsonSerializer.Deserialize<IEnumerable<Docente>>(resp, options);
        }
    }
}
