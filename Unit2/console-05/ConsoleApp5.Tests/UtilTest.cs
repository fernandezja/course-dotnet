using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5;

namespace ConsoleApp5.Tests
{
    public class UtilTest
    {
       
        [Fact]
        public void WorldStringTest()
        {
            //var util = new ConsoleApp5.Util();
            var util = new Util();

            var worldString = util.GetWorld();

            Assert.Equal("World", worldString);
        }
      

        [Fact]
        public void GetGreetingTest()
        {
            var util = new Util();

            //var greeting = util.GetGreeting(".NET");
            //var greeting = util.GetGreeting(".NET", 
            //                                flag: true);

            var greeting = util.GetGreeting(flag: true, 
                                            nameDemo: ".NET");

            Assert.Equal(".NET", greeting);
        }



    }
}
