using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Core.Entities.Tests
{
    public class ArrayTest
    {
        [Fact]
        public void ArrayList_Simple()
        {
            var arraySimple = new ArrayList();

            arraySimple.Add(1);
            arraySimple.Add(100);
            arraySimple.Add(new DateTime());
            arraySimple.Add(new Jedi() {
                Name = "Yoda" });

            Assert.Equal(4, arraySimple.Count);

            var jedi = arraySimple[3];

            //Assert.Equal("Yoda", jedi.Name);

            var jediOption1 = jedi as Jedi;
            Assert.Equal("Yoda", jediOption1.Name);

            var jediOption2 = (Jedi)jedi;
            Assert.Equal("Yoda", jediOption2.Name);
        }
    }
}
