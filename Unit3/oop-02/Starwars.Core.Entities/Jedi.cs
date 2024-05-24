using System.ComponentModel.DataAnnotations;

namespace Starwars.Core.Entities
{
    public class Jedi
    {

        public int JediId { get; private set; }

        public string Name { get; set; }

        private string _description;
        public string Description 
        {
            get
            { 
                return _description;
            }
            set { 
                _description = value;
            }
        }

        public Jedi()
        {
            
        }

        public Jedi(int jediId, string name)
        {
            JediId = jediId;
            Name = name;
        }


    }
}
