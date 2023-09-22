using PortalEstudiantil.AppBlazor.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace PortalEstudiantil.AppBlazor.Services
{
    public class HorarioService : IHorarioService
    {

        //inyección de dependencias de HttpClient
        private readonly HttpClient client;
        public HorarioService(HttpClient httpClient)
        {
            client = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public async Task<IEnumerable<Horario>> GetAll()
        {
            string resp = await client.GetStringAsync($"Horario");
            return JsonSerializer.Deserialize<IEnumerable<Horario>>(resp, options);
        }

        public async Task<IEnumerable<Horario>> GetByDocente(int idDocente)
        {
            var resp = await client.PostAsJsonAsync($"Horario/Buscar", new { DocenteId = idDocente });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Horario>>(respString, options);
        }

        public async Task<IEnumerable<Horario>> GetByGrado(int idGrado)
        {
            var resp = await client.PostAsJsonAsync($"Horario/Buscar", new { GradoId = idGrado });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Horario>>(respString, options);
        }

        public Task<Horario> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Horario>> GetByMateria(int idMateria)
        {
            var resp = await client.PostAsJsonAsync($"Horario/Buscar", new { MateriaId = idMateria });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Horario>>(respString, options);
        }
    }
}
