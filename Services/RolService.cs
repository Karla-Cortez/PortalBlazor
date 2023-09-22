using PortalEstudiantil.AppBlazor.Models;
using System.Net.Http;
using System.Text.Json;

namespace PortalEstudiantil.AppBlazor.Services
{
    public class RolService : IRolService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient client;
        public RolService(HttpClient httpClient)
        {
            client = httpClient;
        }

        public async Task<IEnumerable<Rol>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await client.GetStringAsync($"Rol");
            return JsonSerializer.Deserialize<IEnumerable<Rol>>(resp, options);
        }
    }
}
