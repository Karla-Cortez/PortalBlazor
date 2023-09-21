namespace PortalEstudiantil.AppBlazor.Models
{
    public class Docente
    {
      
        public Int16 Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string CodigoDocente { get; set; }

        public string Clave { get; set; }

  
        public Int16 RolId { get; set; }

        public Int16 MateriaId { get; set; }

        public Int16 CicloId { get; set; }

        public Int16 TurnoId { get; set; }

        public Int32 DUI { get; set; }

        public string Correo { get; set; }

        public string Dirección { get; set; }

        public Int32 Telefono { get; set; }
  
        public int Top_Aux { get; set; }
        
        public string ConfirmPassword_aux { get; set; }
    }
}
