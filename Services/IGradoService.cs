using PortalEstudiantil.AppBlazor.Models;
using System;

namespace PortalEstudiantil.AppBlazor.Services
{
    public interface IGradoService
    {

        Task<IEnumerable<Grado>> GetAll();
    }
}
