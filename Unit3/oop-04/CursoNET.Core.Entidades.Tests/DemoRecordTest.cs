using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoNET.Core.Entidades.Tests
{
    
    public  class DemoRecordTest
    {
        [Fact]
        public void Test_Record() { 
            var demo1 = new DemoRecord("Demo Nombre", "Demo Apellido");

            Assert.Equal("Demo Nombre", demo1.Nombre);

            //demo1.Nombre = "Otro Nombre"; // Esto no compila, ya que los records son inmutables por defecto
        }

        [Fact]
        public void Test_Record_Igualdad()
        {
            var demo1 = new DemoRecord("Demo Nombre", "Demo Apellido");
            var demo2 = new DemoRecord("Demo Nombre", "Demo Apellido");

            Assert.Equal(demo1, demo2);
        }

        [Fact]  
        public void Test_Record_Saludo()
        {
            var demo1 = new DemoRecord("Demo Nombre", "Demo Apellido");
            Assert.Equal("Hola, Demo Nombre", demo1.Saludar());
        }

        [Fact]
        public void Test_Record_Instancias()
        {
            var demo1 = new DemoRecord("Demo Nombre", "Demo Apellido");
            var demo2 = demo1;
            Assert.Equal(demo1, demo2);
            Assert.True(demo1 == demo2); // Los records implementan igualdad estructural por defecto
        }

        [Fact]
        public void Test_Record_Constructor()
        {
            var demo1 = new DemoRecord("Demo Nombre", "Demo Apellido");
            Assert.Equal("DemoRecord { Nombre = Demo Nombre, Apellido = Demo Apellido }", demo1.ToString());
        }
    }
}
