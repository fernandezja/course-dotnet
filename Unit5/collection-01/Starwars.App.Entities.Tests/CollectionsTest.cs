using System.Drawing;
using System.Globalization;

namespace Starwars.App.Entities.Tests
{
    public class CollectionsTest
    {
        [Fact]
        public void cast_test()
        {
            var jedi1 = new Jedi()
            {
                Name = "Yoda"
            };

            var d1 = DateTime.Now;

            //jedi1 = (Jedi)d1;
            //jedi1 = d1 as Jedi;


            var obj1 = (object)jedi1;
            var obj2 = (object)d1;

            //jedi1 = (Jedi)obj2;

        }


        [Fact]
        public void list_generic_add()
        {
            var jedi1 = new Jedi()
            {
                Name = "Yoda"
            };

            var jedis = new System.Collections.Generic.List<Jedi>();

            jedis.Add(jedi1);

            Assert.True(jedis.Contains(jedi1));
            Assert.Equal(1, jedis.Count);

        }




    }
}