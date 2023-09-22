using PortalEstudiantil.AppBlazor.Models;
using System.Text.Json;

namespace PortalEstudiantil.AppBlazor.Services
{
    public class CicloService : ICicloService
    {

        //inyección de dependencias de HttpClient
        private readonly HttpClient client;
        public CicloService(HttpClient httpClient)
        {
            client = httpClient;
        }

        public async Task<IEnumerable<Ciclo>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await client.GetStringAsync($"Ciclo");
            return JsonSerializer.Deserialize<IEnumerable<Ciclo>>(resp, options);
        }
    }
}
