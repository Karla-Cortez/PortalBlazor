using PortalEstudiantil.AppBlazor.Models;



namespace PortalEstudiantil.AppBlazor.Services
{
    public interface IDocenteService
    {
        Task<IEnumerable<Docente>> GetAll();
    }
}
