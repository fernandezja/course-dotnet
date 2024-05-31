

using Classroom.Core.Entities.Interfaces;

namespace Classroom.Core.Entities
{
    public abstract class Person : PersonBase,
                                   IWithLastName,
                                   IWithFirstNameAndLastName, 
                                   IPerson
    {
        public string DemoPublic;
        private string DemoPrivate;

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName { get;  set; }
        public DateOnly Birthdate { get; set; }

        public string FullName
        {
            get {
                return $"{FirstName} {LastName}";
            }
        }

        public int Age
        {
            get
            { 
                return this.AgeCalc(Birthdate);
            }
        }


        public override int AgeCalc(DateOnly birthdate)
        {
            return base.AgeCalc(birthdate) - 2;
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

        public override string ToString()
        {
            return FullName;
        }


    }
}
