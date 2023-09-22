using PortalEstudiantil.AppBlazor.Models;

namespace PortalEstudiantil.AppBlazor.Services
{
    public interface ICicloService
    {
        Task<IEnumerable<Ciclo>> GetAll();
    }
}
