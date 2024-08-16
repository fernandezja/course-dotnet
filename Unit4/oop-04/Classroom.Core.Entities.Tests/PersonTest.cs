namespace Classroom.Core.Entities.Tests
{
    public class PersonTest
    {
        [Fact]
        public void Course_Simple_Test()
        {
            var t1 = new Teacher();

            var s1 = new Student();


            t1.MethodTeacher();

            Person person1 = t1;

            ((Teacher)person1).MethodTeacher();

            Teacher teacher2 = (Teacher)person1;

            Student student2 = (Student)person1;
            Student student3 = person1 as Student;

            Assert.Equal(".NET", person1.Name);
        }


    }
}