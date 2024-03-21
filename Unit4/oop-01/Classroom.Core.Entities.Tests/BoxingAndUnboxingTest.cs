using Classroom.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Tests
{
    public class BoxingAndUnboxingTest
    {

        [Fact]
        public void demo_unboxing()
        {
            var s1 = new Student();
            s1.FirstName = "Student 1";
            s1.LastName = "LastName 1";

            var t1 = new Teacher();
            t1.FirstName = "Teacher 1";
            t1.LastName = "Teacher 1";



            Assert.Equal("Student 1 LastName 1", s1.ToString());
            Assert.Equal("Student 1 LastName 1", s1.FullName);

            //s1.Study()

            Person p1 = s1;
            IPerson p2 = s1;
            IWithLastName p3 = s1;

            Assert.Equal("Student 1", p2.FirstName);
            //p1.Study();
            //p3.LastName

            p2 = t1;
            Assert.Equal("Teacher 1", p2.FirstName);


            var p4 = (IWithLastName)s1;
            var p5 = s1 as IWithLastName;

        }

        [Fact]
        public void demo_unboxing_2()
        {
            var s1 = new Student();
            s1.FirstName = "Student 1";
            s1.LastName = "LastName 1";

            var t1 = new Teacher();
            t1.FirstName = "Teacher 1";
            t1.LastName = "Teacher 1";


            var person1 = (Person)s1;

            IPerson p2 = s1;

            //var teacher1 = (Teacher)p2;

            //    System.InvalidCastException :
            //    Unable to cast object of type 'Classroom.Core.Entities.Student'
            //    to type 'Classroom.Core.Entities.Teacher'.

            //Assert.Equal("Student 1", teacher1.FirstName);

           


        }
    }
}
