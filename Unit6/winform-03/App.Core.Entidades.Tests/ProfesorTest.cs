namespace App.Core.Entidades.Tests
{
    public class ProfesorTest
    {
        [Fact]
        public void DebeDevolverLaEdad()
        {
           var profesor = new Profesor("Profesor 1");
           profesor.FechaNacimiento = new DateTime(2000, 1, 1);


           Assert.Equal(24, profesor.Edad);
        }

        [Fact]
        public void ToStringDebeDevolverNombreYEdad()
        {
            var profesor = new Profesor("Profesor 1");
            profesor.FechaNacimiento = new DateTime(2000, 1, 1);

            Assert.Equal(24, profesor.Edad);
            Assert.Equal("PROFESOR: Profesor 1 (Edad 24)", profesor.ToString());
        }

    }
}