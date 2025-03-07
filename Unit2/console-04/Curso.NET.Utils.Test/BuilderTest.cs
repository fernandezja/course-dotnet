using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.NET.Utils.Test
{
    public class BuilderTest
    {

        [Fact]
        public void BuildTest()
        {
            //acciones
            var resultado = Curso.NET.Utils.Builder.Build("Demo");

            //verificacion
            Assert.Equal("Hello, Demo", resultado);
        }
    }
}
