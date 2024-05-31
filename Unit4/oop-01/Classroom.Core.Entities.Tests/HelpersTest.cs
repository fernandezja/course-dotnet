using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Tests
{
    public class HelpersTest
    {
        [Fact]
        public void Demo()
        {
            var result = Helpers.Demo();


            Assert.Equal("Demo", result);

        }
    }
}
