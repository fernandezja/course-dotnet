using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Tests
{
    public class TeacherTest
    {
        [Fact]
        public void TestTeacherCreation()
        {
           
            var teacher = new Teacher
            {
                Name = "Jane",
                LastName = "Smith"
            };

            //teacher.Private1

            Assert.Equal("Jane", teacher.Name);
            Assert.Equal("Smith", teacher.LastName);
            Assert.Equal("MethodTeacher", teacher.MethodTeacher());

        }
    }
}
