using PortalEstudiantil.AppBlazor.Models;
using System;

namespace PortalEstudiantil.AppBlazor.Services
{
    public interface IRolService
    {
        Task<IEnumerable<Rol>> GetAll();
    }
}
