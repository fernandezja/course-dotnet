namespace ConsoleApp1.Tests
{
    public class PersonTest
    {
        [Fact]
        public void create_a_person()
        {
            var p1 = new Person();
            p1.Name = "Test";
            p1.LastName = "Demo";

            Assert.Equal("Test Demo", p1.FullName);

        }


        [Fact]
        public void verify_name_ends_with_string_double_zero()
        {
            var p1 = new Person();
            p1.Name = "Test00";
            p1.LastName = "Demo";

            //Assert.Equal(true, p1.NameEndsWithDoubleZero());
            Assert.True(p1.NameEndsWithDoubleZero);
        }

        [Fact]
        public void verify_name_not_ends_with_string_double_zero()
        {
            var p1 = new Person();
            p1.Name = "Test99";
            p1.LastName = "Demo";

            //Assert.Equal(false, p1.NameEndsWithDoubleZero());
            Assert.False(p1.NameEndsWithDoubleZero);
        }



        [Theory]
        [InlineData("Test99", false)]
        [InlineData("Test00", true)]
        [InlineData("", false)]
        [InlineData("T", false)]
        public void verify_NameEndsWithDoubleZero(
                    string name,
                    bool expectedValue)
        {
            var p1 = new Person();
            p1.Name = name;
            p1.LastName = "Demo";

            //Assert.Equal(false, p1.NameEndsWithDoubleZero());
            Assert.Equal(expectedValue, p1.NameEndsWithDoubleZero);
        }

    }
}