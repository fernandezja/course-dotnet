using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Entidades.Tests
{
    public class PersonaBaseTest
    {
        //[Fact]
        //public void DemoAbstract()
        //{
        //    var p1 = new PersonaBase("Persona 1");

        //    Assert.Equal("Persona 1", p1.Nombre);
        //}
        [Fact]
        public void MetodoEstatico()
        {
            var resultado = PersonaBase.Metodo2();

            Assert.Equal("Metodo2", resultado);
        }
    }
}
