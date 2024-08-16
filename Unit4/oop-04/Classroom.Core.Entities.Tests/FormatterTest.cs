namespace Classroom.Core.Entities.Tests
{
    public class FormatterTest
    {
        [Fact]
        public void FormatName_Test()
        {
            

            var result = Formatter.FormatName(new Teacher() { 
                                                Name = "J", 
                                                LastName = "F" 
                                                });

            Assert.Equal("J F", result);
        }


    }
}