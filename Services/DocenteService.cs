using PortalEstudiantil.AppBlazor.Models;
using System.Net.Http;
using System.Net.Http.Json;
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
            var resp = await client.PostAsJsonAsync ($"Docente/Buscar", new { top_aux = 10});

            string respString = await resp.Content.ReadAsStringAsync(); 
            return JsonSerializer.Deserialize<IEnumerable<Docente>>(respString, options);
        }
    }
}
