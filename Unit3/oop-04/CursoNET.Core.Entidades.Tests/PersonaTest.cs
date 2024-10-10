namespace CursoNET.Core.Entidades.Tests
{
    public class PersonaTest
    {
        [Fact]
        public void Debe_crear_una_persona()
        {
            var persona1 = new Persona("Demo", "Test");

            Assert.Equal("Demo", persona1.Nombre);
            Assert.Equal("Test", persona1.Apellido);
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

            Assert.Equal(44, persona1.Edad());
        }


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

    }
}
