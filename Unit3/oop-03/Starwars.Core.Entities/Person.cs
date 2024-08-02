
namespace Starwars.Core.Entities
{
    public class Person: IDisposable
    {

        private string _name;

        public string Name
        {
            get { 
                return _name;
            }
            set { 
                _name = value;
            }
        }

        public int PersonId { get; private set; }

        public string Lastname { get; set; }

        public Person()
        {
            
        }

        public Person(int personId)
        {
            PersonId = personId;
        }


        public string Saludar()
        {
            return $"Hello {Name}!";
        }

        public void Dispose()
        {
            //Dispose
        }
    }
}
