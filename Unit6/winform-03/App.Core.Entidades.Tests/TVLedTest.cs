using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Entidades.Tests
{
    public class TVLedTest
    {
        [Fact]
        public void Test() { 
            var tv = new TVLed();

            var profesor1 = new Profesor("Profesor X");
            tv.Imprimir(profesor1);
            Assert.Equal("Profesor X", tv.Pantalla);

            var alumno1 = new Alumno("Alumno 1");
            tv.Imprimir(alumno1);
            Assert.Equal("Alumno 1", tv.Pantalla);

            var curso1 = new Curso("NET 8");
            tv.Imprimir(curso1);
            Assert.Equal("NET 8", tv.Pantalla);

        }
    }
}
