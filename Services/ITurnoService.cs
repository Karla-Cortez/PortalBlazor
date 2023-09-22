using PortalEstudiantil.AppBlazor.Models;

namespace PortalEstudiantil.AppBlazor.Services
{
    public interface ITurnoService
    {
        Task<IEnumerable<Turno>> GetAll();
    }
}
