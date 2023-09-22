using PortalEstudiantil.AppBlazor.Models;
using System.Text.Json;

namespace PortalEstudiantil.AppBlazor.Services
{
    public class TurnoService : ITurnoService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient client;
        public TurnoService(HttpClient httpClient)
        {
            client = httpClient;
        }

        public async Task<IEnumerable<Turno>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await client.GetStringAsync($"Turno");
            return JsonSerializer.Deserialize<IEnumerable<Turno>>(resp, options);
        }
    }
}
