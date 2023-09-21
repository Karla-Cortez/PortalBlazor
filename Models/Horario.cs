using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PortalEstudiantil.AppBlazor.Models
{
    public class Horario
    {
        public Int16 Id { get; set; }

        public Int16 GradoId { get; set; }

        public Int16 MateriaId { get; set; }

        public Int16 DocenteId { get; set; }

        public string Dia { get; set; }

        public string HorarioInicio { get; set; }

        public string HorarioSalida { get; set; }

    }
}
