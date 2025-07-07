using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Tests
{
    public class StudentTests
    {
        [Fact]
        public void TestStudentCreation()
        {
           
            var student = new Student
            {
                Name = "John",
                LastName = "Doe",
                Birthdate = new DateTime(2000, 1, 1)
            };

            //student.Private1

            Assert.Equal("John", student.Name);
            Assert.Equal("Doe", student.LastName);
            Assert.Equal(new DateTime(2000, 1, 1), student.Birthdate);

        }
    }
}
