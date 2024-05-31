namespace Classroom.Core.Entities.Tests
{
    public class DirectorTest
    {
        [Fact]
        public void call_test()
        {
            var d1 = new Director();

            d1.Call(new Student());
            d1.Call(new Teacher());

            d1.Call(new Organization());


            Assert.NotNull(d1);
            
        }

    }
}