using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Core.Entities.Tests
{
    public class DateTest
    {
        [Fact]
        public void Date_Simple_Test()
        {
            var d1 = new DateOnly();

            Assert.Equal(1, d1.Day);
            Assert.Equal(1, d1.Month);
            Assert.Equal(1, d1.Year);

        }

    }
}
