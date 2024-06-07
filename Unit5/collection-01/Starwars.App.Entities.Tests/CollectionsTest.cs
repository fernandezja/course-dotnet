using System.Collections;
using System.Drawing;
using System.Globalization;

namespace Starwars.App.Entities.Tests
{
    public class CollectionTest
    {

        [Fact]
        public void ArrayList_Test()
        {
            var autos = new ArrayList(10);
            autos.Add("Volvo");
            autos.Add("BMW");

            autos.Add(1);
            autos.Add(new DateTime());

            //((DateTime)(autos[3])).Day;

            Assert.Equal(4, autos.Count);
            

        }

        [Fact]
        public void demo1()
        {
            string[] autos = new string[4];
            autos[0] = "Volvo";
            autos[1] = "BMW";
            //autos[2] = new DateTime();

            Assert.Equal(4, autos.Length);
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



        [Fact]
        public void Generic_List_Test()
        {
            var jedi1 = new Jedi()
            {
                Name = "Yoda"
            };

            var jedis = new List<Jedi>();
            jedis.Add(jedi1);

            Assert.Equal("Yoda", jedis[0].Name);
            Assert.Equal("Yoda", jedis.First().Name);
            Assert.Equal("Yoda", jedis.Last().Name);

        }

    }
}