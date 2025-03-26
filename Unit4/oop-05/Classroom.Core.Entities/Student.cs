namespace Classroom.Core.Entities
{
    public class Student: Person
    {
        public void Demo1() { 
            //demo 
        }

        public override string Method1()
        {
            //acciones antes
            var result = base.Method1();
            //acciones antes
            return result;
        }

        public override string ToString()
        {
            return $"{Name} {LastName} (ALUMNO)";
        }

        //public static Student operator +(Student a, Student b)
        //=> new Student() ;

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
