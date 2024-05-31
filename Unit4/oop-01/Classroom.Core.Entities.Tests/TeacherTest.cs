namespace Classroom.Core.Entities.Tests
{
    public class TeacherTest
    {
        [Fact]
        public void create_a_teacher()
        {
            var t1 = new Teacher();
            t1.FirstName = "Teacher1";
            t1.LastName = "Teacher1";


            Assert.Equal("Teacher1", t1.FirstName);
            Assert.Equal("Teacher1", t1.LastName);
            
        }

    }
}