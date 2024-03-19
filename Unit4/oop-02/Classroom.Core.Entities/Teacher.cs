
namespace Classroom.Core.Entities
{
    public class Teacher
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
