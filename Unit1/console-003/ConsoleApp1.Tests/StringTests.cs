using System.Text;

namespace ConsoleApp1.Tests
{
    public class StringTests
    {
        [Fact]
        public void String_concat_many_instances()
        {
            const string DEMO_STRING = "demo";

            var stringTest = string.Empty;

            var sb = new StringBuilder(stringTest);

            for (int i = 0; i < 5000000; i++) 
            {
                //stringTest += DEMO_STRING;
                sb.Append(DEMO_STRING);
            }

            Assert.NotNull(DEMO_STRING);


        }
    }
}