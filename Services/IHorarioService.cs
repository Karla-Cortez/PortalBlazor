using PortalEstudiantil.AppBlazor.Models;

namespace PortalEstudiantil.AppBlazor.Services
{
    public interface IHorarioService
    {
        Task<IEnumerable<Horario>> GetAll();
        Task<IEnumerable<Horario>> GetByGrado(int idGrado);
        Task<IEnumerable<Horario>> GetByMateria(int idMateria);
        Task<IEnumerable<Horario>> GetByDocente(int idDocente);
        Task<Horario> GetById(int id);
    }
}
