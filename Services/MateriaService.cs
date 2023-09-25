using PortalEstudiantil.AppBlazor.Models;
using System.Net.Http;
using System.Text.Json;

namespace PortalEstudiantil.AppBlazor.Services
{
    public class MateriaService : IMateriaService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient client;
        public MateriaService(HttpClient httpClient)
        {
            client = httpClient;
        }

        public async Task<IEnumerable<Materia>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await client.GetStringAsync($"Materia");
            return JsonSerializer.Deserialize<IEnumerable<Materia>>(resp, options);
        }
    }
}
