using PortalEstudiantil.AppBlazor.Models;
using System;

namespace PortalEstudiantil.AppBlazor.Services
{
    public interface IMateriaService
    {
        Task<IEnumerable<Materia>> GetAll();

    }
}
