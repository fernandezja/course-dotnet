namespace Classroom.Core.Entities.Tests
{
    public class CourseTest
    {
        [Fact]
        public void Simple_Course()
        {
            var course1 = new Course();
            course1.Title = ".NET";

            Assert.NotNull(course1);
            Assert.Equal(".NET", course1.Title);
        }


        [Fact]
        public void Add_Teacher()
        {
            var course1 = new Course();
            course1.Title = ".NET";
            course1.Teacher = new Teacher { 
                Name = "John",
                LastName = "Doe"
            };

            Assert.NotNull(course1);
            Assert.Equal(".NET", course1.Title);
            Assert.Equal("John", course1.Teacher.Name);
            Assert.Equal("Doe", course1.Teacher.LastName);
        }


        [Fact]
        public void Add_Students()
        {
            var course1 = new Course();
            course1.Title = ".NET";

            for (int i = 1; i <= 10; i++)
            {
                var student = new Student
                {
                    Name = $"Student {i}",
                    LastName = $"Lastname {i}"
                };

                course1.Add(student);

            }

            Assert.NotNull(course1);
            Assert.Equal(".NET", course1.Title);
            Assert.Equal(10, course1.Students.Count);
        }
    }
}
