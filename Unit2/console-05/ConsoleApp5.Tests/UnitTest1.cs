using System.Numerics;


namespace ConsoleApp5.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var demo = "World"; 

            Assert.Equal("World", demo);
        }


        [Fact]
        public void Test2()
        {
            int sum = 1 + 2;
            var resultado2 = GetResultado2();


            Assert.Equal(3, sum);
            Assert.Equal(3, resultado2);
        }

        private static int GetResultado2()
        {
            return 1 + 2;
        }

        [Fact]
        public void Test3()
        {
            string demo = "World" 
                         + " .NET"
                         + " 9";
            

            var demoLength = demo.Length
                                 .ToString();


            Assert.Equal("World .NET 9", demo);
            Assert.Equal("12", demoLength);
        }


        [Fact]
        public void Test5()
        {
            var demo = "World";

            switch (demo)
            {
                case "World":
                case "Demo":
                    Assert.Equal("World", demo);
                    break;
                case "Hello":
                    Assert.Equal("Hello", demo);
                    break;
                default:
                    Assert.Equal("FINAL", demo);
                    break;
            }


        }


        [Fact]
        public void Test4()
        {
            int value1 = 10;
            
            for (int i = 0; i < value1; i++)
            {
                if (i == 2)
                    continue;

                if (i == 5)
                    continue;

                value1 += i;
            }

            Assert.Equal(55, value1);   
        }


    }
}
