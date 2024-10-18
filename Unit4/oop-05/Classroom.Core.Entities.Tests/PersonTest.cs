using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Tests
{

    public class PersonTest
    {
        [Fact]
        public void Test_Student_Teacher_Person()
        {
            Person person1;
            Teacher teacher1;

            Student student = new Student();
            student.Name = "John";
            student.LastName = "Doe";

            person1 = student;

            /*
            Teacher teacher2 = (Teacher)person1;

            Assert.NotNull(teacher2);
            Assert.Equal("John", teacher2.Name);
            Assert.Equal("Doe", teacher2.LastName);
            */

            Teacher teacher2 = person1 as Teacher;

            Assert.Null(teacher2);
        }
    }
}
