using Classroom.Core.Entities.Interfaces;

namespace Classroom.Core.Entities
{
    public abstract class Person: IPerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public DateOnly BirthDate { get; set; }

        public int Age => DateTime.Now.Year - BirthDate.Year;   
    
        public virtual string Method1()
        {
            return $"Hi {Name} (Method1)";
        }

    }
}
