using System.Text;

namespace CursoNET.Core.Entidades.Tests
{
    public class PersonaTest
    {
        [Fact]
        public void Debe_crear_una_persona()
        {
            var persona1 = new Persona("Demo Nombre", "Demo Apellido");

            Assert.Equal("Demo Nombre", persona1.Nombre);
            Assert.Equal("Demo Apellido", persona1.Apellido);

            //persona1.PersonaId = 10;
        }


        [Fact]
        public void Prueba_Igualdad_Entre_Objetos()
        {
            var persona1 = new Persona("Demo Nombre", "Demo Apellido");
            var persona2 = new Persona("Demo Nombre", "Demo Apellido");

            var person3 = persona2;

            Assert.NotEqual(persona1, persona2);

            Assert.Equal(persona2, person3);

            person3.Nombre = "Otro Nombre";
            Assert.Equal("Otro Nombre", persona2.Nombre);


        }



        [Fact]
        public void Metodo_EsIgual()
        {
            var persona1 = new Persona("Demo Nombre", "Demo Apellido");
            var persona2 = new Persona("Demo Nombre", "Demo Apellido");

            Assert.True(persona2.EsIgual(persona1));


        }


        [Fact]
        public void Metodo_Boxing_Unboxing()
        {
            var persona1 = new Persona("Demo Nombre", "Demo Apellido");
            var persona2 = new Persona("Demo Nombre", "Demo Apellido");

            Object obj1 = persona1;

            Assert.Equal("CursoNET.Core.Entidades.Persona", persona1.GetType().ToString());
            Assert.Equal("CursoNET.Core.Entidades.Persona", obj1.GetType().ToString());

            var persona3 = (Persona)obj1;
            var persona4 = obj1 as Persona;

            Assert.Equal("Demo Nombre", persona3.Nombre);
            Assert.Equal("Demo Nombre", persona4.Nombre);


            var dateTime1 = obj1 as StringBuilder;
            Assert.Null(dateTime1);

            //System.InvalidCastException : Unable to cast object of type 'CursoNET.Core.Entidades.Persona' to type 'System.Text.StringBuilder'.
            //var dateTime2 = (StringBuilder)obj1;
            //Assert.Null(dateTime2);


        }


        
        [Theory]
        [InlineData("Demo", "Demo Test")]
        [InlineData("Juan de los Palotes", "Juan de los Palotes Test")]
        public void Debe_obtener_nombre_completo(string nombre, 
                                                 string nombreCompletoEsperado)
        {
            var persona1 = new Persona(nombre, "Test");

            Assert.Equal(nombreCompletoEsperado, persona1.NombreCompleto);
        }


       

        [Fact]
        public void Debe_obtener_la_edad()
        {
            var persona1 = new Persona("Demo", "Test");
            persona1.FechaNacimiento = new DateTime(1980, 1, 1);

            Assert.Equal(45, persona1.Edad);
        }
        /*

        [Fact]
        public void Identidad_de_objetos()
        {
            var persona1 = new Persona("Demo", "Test");
            var persona2 = new Persona("Demo", "Test");

            Assert.False(persona1 == persona2);
        
            var persona3 = persona1;

            Assert.True(persona1 == persona3);

            persona3.CambiarNombre("Otro");

            Assert.Equal("Otro", persona1.Nombre);
            Assert.Equal("Demo", persona2.Nombre);
            Assert.Equal("Otro", persona3.Nombre);


        }
        */
    }
}
