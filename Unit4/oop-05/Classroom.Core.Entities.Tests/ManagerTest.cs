using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Tests
{
    public class ManagerTest
    {
        [Fact]
        public void Test_Method1() 
        {
            var student = new Student() { 
                Name  = "Student A"
            };

            var result = Manager.Method1(student);

            Assert.Equal("Hi Student A", result);


            var teacher = new Teacher()
            {
                Name = "Teacher B"
            };

            Assert.Equal("Hi Teacher B", Manager.Method1(teacher));

            var building1 = new Building()
            {
                Name = "Building Space X"
            };

            Assert.Equal("Hi Building Space X", Manager.Method1(building1));

        }
    }
}
