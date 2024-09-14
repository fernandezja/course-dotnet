using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace Starwars.Core.Entities
{
    [Table("Empleado", Schema = "dbo")]
    public class Empleado
    {
        //[Key]
        public int Id { get; set; }
        [Column("NombreCompleto")]
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public int Edad { get; set; }
        public bool Casado { get; set; }

    }
}
