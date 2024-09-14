namespace App.Core.Entidades.Tests
{
    public class AlumnoTest
    {
        [Fact]
        public void DebeDevolverLaEdad()
        {
           var alumno = new Alumno("Alumno 1");
           alumno.FechaNacimiento = new DateTime(2000, 1, 1);

           Assert.Equal(24, alumno.Edad);
        }

        [Fact]
        public void ToStringDebeDevolverNombreYEdad()
        {
            var alumno = new Alumno("Alumno 1");
            alumno.FechaNacimiento = new DateTime(2000, 1, 1);

            Assert.Equal(24, alumno.Edad);
            Assert.Equal("Alumno 1 (Edad 24)", alumno.ToString());
        }

    }
}