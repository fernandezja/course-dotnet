using System.Collections;
using System.Drawing;
using System.Globalization;

namespace Starwars.App.Entities.Tests
{
    public class CollectionTest
    {

        [Fact]
        public void demo1()
        {
            string[] autos = new string[4];
            autos[0] = "Volvo";
            autos[1] = "BMW";

        }

        [Fact]
        public void demo()
        {
            var jedi1 = new Jedi()
            {
                Name = "Yoda"
            };

            Array array0; //Array abstract

            var array1 = new ArrayList(5);
            //var array2 = new Jedi[5];

            array1.Add(jedi1);
            array1.Add(new DateTime(2024, 3, 26, 17, 35, 0));
            array1.Add(".NET");

            var demo1 = array1[1];
            var demo2 = array1[2];
            

            Assert.Equal("26/3/2024 17:35:00", demo1.ToString());
            Assert.Equal(".NET", demo2.ToString());

        }

        

    }
}