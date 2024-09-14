using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Entidades.Tests
{
    public class PooIdentidadTest
    {
        [Fact]
        public void IdentidadDeUnObjeto()
        {
            var alumno1 = new Alumno("Alumno 1");
            var alumno2 = new Alumno("Alumno 1");

            Assert.Equal(0, alumno1.Edad);
            Assert.Equal(0, alumno2.Edad);

            Assert.Equal(false, alumno1 == alumno2);
            Assert.Equal(false, alumno1.Equals(alumno2));

            var alumno3 = alumno1;
            Assert.Equal(true, alumno1 == alumno3);

            alumno3.FechaNacimiento = new DateTime(2000, 1, 1);
            Assert.Equal(24, alumno1.Edad);
            Assert.Equal(24, alumno3.Edad);
        }
    }
}
