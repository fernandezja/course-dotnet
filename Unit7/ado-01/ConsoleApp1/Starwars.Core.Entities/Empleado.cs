using System.Net;

namespace Starwars.Core.Entities
{
    //[Table("Empleados", Schema = "dbo")]

    public class Empleado
    {
        //[Key]
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public int Edad { get; set; }
        public bool Casado { get; set; }

    }
}
