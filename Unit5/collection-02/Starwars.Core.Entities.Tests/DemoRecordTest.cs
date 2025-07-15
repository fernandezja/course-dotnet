using Starwars.Core.Entities;
using System.Globalization;

namespace Starwars.Core.Entities.Tests
{
    public class DemoRecordTest
    {
        [Fact]
        public void DemoTest()
        {

            var point1 = new DemoRecord("Demo1", "Demo2");
            var point2 = new DemoRecord("Demo1", "Demo2");

            Assert.Equal("Demo1", point1.FirstName);
            Assert.Equal("Demo2", point1.LastName);

            //Igualdad de "propiedades" en un record
            Assert.Equal(point1, point2);

            //point1.FirstName = "UpdatedDemo1";

        }


    }
}