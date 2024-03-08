namespace Unit3.Core.Entities.Tests
{
    public class PersonaTests
    {
        [Fact]
        public void Should_create_a_person_with_firstName()
        {
            var p = new Person("FirstName Test");

            Assert.Equal("FirstName Test", p.FirstName);
            Assert.Equal(string.Empty, p.LastName);
            
        }

        [Fact]
        public void Should_a_person_set_Birthdate_return_Age()
        {
            var p = new Person("FirstName Test");
            p.Birthdate = new DateOnly(2000, 1, 1);

            Assert.Equal("FirstName Test", p.FirstName);
            Assert.Equal(string.Empty, p.LastName);
            Assert.Equal(24, p.Age);
        }


        [Theory]
        [InlineData(2000, 1, 1, 24)]
        [InlineData(2003, 1, 1, 21)]
        public void Should_a_person_set_Birthdate_return_Age_multiple(
                        int year, int month, int day, int ageExpected)
        {
            var p = new Person("FirstName Test");
            p.Birthdate = new DateOnly(year, month, day);

            Assert.Equal("FirstName Test", p.FirstName);
            Assert.Equal(string.Empty, p.LastName);
            Assert.Equal(ageExpected, p.Age);
        }
    }
}