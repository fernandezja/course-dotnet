namespace Classroom.Core.Entities
{
    public abstract class Person : INameAndLastName,
                                   IName   
    {
        private int Private1 { get; set; }

        public string LastName { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public virtual int Age() {
            return 0;
        }
    }
}