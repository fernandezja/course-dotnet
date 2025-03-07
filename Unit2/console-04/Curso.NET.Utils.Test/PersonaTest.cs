using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.NET.Utils.Test
{
    public class PersonaTest
    {

        [Fact]
        public void DebeCrearUnObjetoPersona()
        {
            
            var persona1 = new Persona();
            persona1.Nombre = "Curso .NET";   

            
            Assert.NotNull(persona1);
            Assert.Equal("Curso .NET", persona1.Nombre);
        }


    }
}
