
using Classroom.Core.Entities.Interfaces;

namespace Classroom.Core.Entities
{
    public class Teacher: IWithFullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName {
            get 
            {
                return $"{FirstName} {LastName}".Trim();
            }
        }
    }
}
