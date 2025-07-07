using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Tests
{
    public class TvLedTest
    {
        [Fact]
        public void TvLedPrintTeacher()
        {
            var tvLed1 = new TvLed();

            var teacher1 = new Teacher
            {
                Name = "John",
                LastName = "Doe"
            };

            var result = tvLed1.Print(teacher1);

            Assert.Equal("SHOW John", result);
        }


        [Fact]
        public void TvLedPrintStudent()
        {
            var tvLed1 = new TvLed();

            var student1 = new Student
            {
                Name = "Jane",
                LastName = "Smith"
            };
            

            var result = tvLed1.Print(student1);

            Assert.Equal("SHOW Jane", result);
        }


        [Fact]
        public void TvLedPrintCourse()
        {
            var tvLed1 = new TvLed();

            var course1 = new Course
            {
                Name = ".NET"
            };


            var result = tvLed1.Print(course1);

            Assert.Equal("SHOW .NET", result);
        }
    }
}
