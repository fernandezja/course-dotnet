namespace Classroom.Core.Entities
{
    public class Teacher: Person
    {
        public string MethodTeacher() {
            
            return "MethodTeacher";
        }

        public override int Age()
        {
            throw new ApplicationException("Demo error");
        }
    }
}
