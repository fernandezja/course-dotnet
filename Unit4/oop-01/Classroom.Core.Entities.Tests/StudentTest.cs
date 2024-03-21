using Classroom.Core.Entities.Interfaces;

namespace Classroom.Core.Entities.Tests
{
    public class StudentTest
    {
        [Fact]
        public void Should_be_create_a_student()
        {
            var s1 = new Student();
            s1.FirstName = "Student 1";
            s1.LastName = "LastName 1";


            Assert.Equal("Student 1", s1.FirstName);
            Assert.Equal("LastName 1", s1.LastName);
            
        }

        [Fact]
        public void Should_be_call_toDo_method()
        {
            var s1 = new Student();

            Assert.Equal("ToDo in Student", s1.ToDo());

        }


        [Fact]
        public void Should_be_create_a_student_with_firstName()
        {
            var p = new Student("FirstName Test");

            Assert.Equal("FirstName Test", p.FirstName);
            Assert.Equal(string.Empty, p.LastName);

        }

        [Fact]
        public void Should_be_create_a_student_set_Birthdate_return_Age()
        {
            var p = new Student("FirstName Test");
            p.Birthdate = new DateOnly(2000, 1, 1);

            Assert.Equal("FirstName Test", p.FirstName);
            Assert.Equal(string.Empty, p.LastName);
            Assert.Equal(24, p.Age);
        }


        [Theory]
        [InlineData(2000, 1, 1, 24)]
        [InlineData(2003, 1, 1, 21)]
        public void Should_be_create_a_student_set_Birthdate_return_Age_multiple(
                        int year, int month, int day, int ageExpected)
        {
            var p = new Student("FirstName Test");
            p.Birthdate = new DateOnly(year, month, day);

            Assert.Equal("FirstName Test", p.FirstName);
            Assert.Equal(string.Empty, p.LastName);
            Assert.Equal(ageExpected, p.Age);
        }


        [Fact]
        public void demo_toString()
        {
            var s1 = new Student();
            s1.FirstName = "Student 1";
            s1.LastName = "LastName 1";


            Assert.Equal("Student 1 LastName 1", s1.ToString());

        }

        [Fact]
        public void demo_toString2()
        {
            var s1 = new Student();
            s1.FirstName = "Student 1";
            s1.LastName = "LastName 1";


            Assert.Equal("Student 1 LastName 1", s1.ToString());

        }


        [Fact]
        public void demo_unboxing()
        {
            var s1 = new Student();
            s1.FirstName = "Student 1";
            s1.LastName = "LastName 1";


            Assert.Equal("Student 1 LastName 1", s1.ToString());

            //s1.Study()

            Person p1 = s1;
            IPerson p2 = s1;
            IWithLastName p3 = s1;

            //p1.Study();
            //p3.LastName

            var p4 = (IWithLastName)s1;
            var p5 = s1 as IWithLastName;

        }
    }
}