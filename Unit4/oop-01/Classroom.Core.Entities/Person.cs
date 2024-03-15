

using Classroom.Core.Entities.Interfaces;

namespace Classroom.Core.Entities
{
    public abstract class Person : IWithLastName,
                          IWithFirstNameAndLastName, IPerson
    {
        public string DemoPublic;
        private string DemoPrivate;

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName { get; set; }
        public DateOnly Birthdate { get; set; }

        public int Age
        {
            get
            {
                return AgeCalc();
            }
        }


        private int AgeCalc()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var age = today.Year - Birthdate.Year;
            if (Birthdate > today.AddYears(-age)) age--;
            return age;
        }

        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName)
        {
            FirstName = firstName;
            LastName = string.Empty;
        }

        public virtual string ToDo()
        {
            return "ToDo";
        }


    }
}
