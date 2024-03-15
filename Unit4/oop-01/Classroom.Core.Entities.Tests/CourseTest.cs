namespace Classroom.Core.Entities.Tests
{
    public class CourseTest
    {
        [Fact]
        public void create_a_course_with_the_teacher()
        {
            var c1 = new Course() { 
                Title ="Course .NET"
            };

            var t1 = new Teacher();
            t1.FirstName = "Teacher1";
            t1.LastName = "LastName1";

            c1.Teacher = t1;
 

            Assert.Equal("Course .NET", c1.Title);
            Assert.Equal("Teacher1", c1.Teacher.FirstName);
            Assert.Equal("LastName1", c1.Teacher.LastName);
            
        }


        [Fact]
        public void create_a_course_with_the_teacher_2()
        {

            var t1 = new Teacher();
            t1.FirstName = "Teacher1";
            t1.LastName = "LastName1";

            var c1 = new Course("Course .NET", t1);


            Assert.Equal("Course .NET", c1.Title);
            Assert.Equal("Teacher1", c1.Teacher.FirstName);
            Assert.Equal("LastName1", c1.Teacher.LastName);

        }


        [Fact]
        public void create_a_course_with_students()
        {
            var c1 = new Course()
            {
                Title = "Course .NET"
            };

            for (int i = 0; i < 10; i++) { 
                var s = new Student() { 
                    FirstName = $"Student {i}"
                };

                c1.Add(s);
            };

            //c1.Students = new List<Student>();
            c1.Add(new List<Student>());

            Assert.Equal("Course .NET", c1.Title);
            Assert.Equal("Student 0", c1.Students[0].FirstName);
            Assert.Equal("Student 9", c1.Students[9].FirstName);
            Assert.Equal(10, c1.Students.Count);

        }

    }
}