using PortalEstudiantil.AppBlazor.Models;
using System;

namespace PortalEstudiantil.AppBlazor.Services
{
    public interface IDocenteService
    {

        Task<IEnumerable<Docente>> GetAll();
    }
}