namespace Classroom.Core.Entities
{
    public abstract class Person: INameAndLastName
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public virtual int Age() {
            return 0;
        }
    }
}