using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Starwars.Core.Entities
{
    [Table("Jedi")]
    public class Jedi
    {
        public int JediId { get; set; }

        [Column("FirstName")]
        public string Name { get; set; }


        public string Email { get; set; }


        public override string ToString()
        {
            return $"{Name} ({JediId}) {Email}";
        }

    }
}
