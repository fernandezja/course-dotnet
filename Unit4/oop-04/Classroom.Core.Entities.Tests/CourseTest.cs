namespace Classroom.Core.Entities.Tests
{
    public class CourseTest
    {
        [Fact]
        public void Course_Simple_Test()
        {
            var course1 = new Course();
            course1.Title = ".NET";

            Assert.Equal(".NET", course1.Title);
        }



        [Fact]
        public void Course_With_Teacher()
        {
            var course1 = new Course();
            course1.Title = ".NET";

            var teacher1 = new Teacher();
            teacher1.Name = "J";
            teacher1.LastName = "F";

            course1.Teacher = teacher1;

            Assert.Equal("J", course1.Teacher.Name);
            Assert.Equal("F", course1.Teacher.LastName);
        }


        [Fact]
        public void Course_With_Students()
        {
            var course1 = new Course();
            course1.Title = ".NET";

            var s1 = new Student() {
                Name = "Student 1",
                LastName = "F 1"
            };

            var s2 = new Student()
            {
                Name = "Student 2",
                LastName = "F 2"
            };

            var students = new List<Student>();
            students.Add(s1);
            students.Add(s2);

            course1.Students = students;

            Assert.Equal(2, course1.Students.Count);
            Assert.Equal("Student 1", course1.Students[0].Name);
            Assert.Equal("Student 1", course1.Students.First().Name);
        }
    }
}