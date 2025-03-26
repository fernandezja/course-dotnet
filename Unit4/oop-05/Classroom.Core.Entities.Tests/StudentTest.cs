using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Tests
{

    public class StudentTest
    {
        [Fact]
        public void Test_Student()
        {
            var student = new Student
            {
                Name = "John",
                LastName = "Doe",
                BirthDate = new DateOnly(2000, 1, 1)
            };

            Assert.Equal("John", student.Name);
            Assert.Equal("Doe", student.LastName);
            Assert.Equal(24, student.Age);
        }

        [Fact]
        public void Person_Student_Test()
        {
            Person person1;
            Object person2;

            Student student = new Student();
            student.Name = "John";
            student.LastName = "Doe";

            person1 = student;
            person2 = student;


            Assert.NotNull(person1);
            Assert.NotNull(person2);


            Student student2 = (Student)person1;

            Assert.NotNull(student2);
            Assert.Equal("John", student2.Name);
            Assert.Equal("Doe", student2.LastName);

            Student student3 = person1 as Student;
            Assert.NotNull(student3);
        }
    }
}
