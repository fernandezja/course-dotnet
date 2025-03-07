namespace Curso.NET.Utils.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestSumarUnoMasUnoYDebeDarDos()
        {
            //acciones
            var resultado = 1 + 1;

            //verificacion
            Assert.Equal(2, resultado);
        }


        [Fact]
        public void TestSumarUnoMasDosYDebeDarTres()
        {
            //acciones
            var resultado = 1 + 2;

            //verificacion
            Assert.Equal(3, resultado);
        }
    }
}
