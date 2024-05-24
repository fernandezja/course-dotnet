namespace Starwars.Core.Entities.Test
{
    public class UnitTest1
    {


        [Fact]
        public void Test1_Suma_DebeDevolver2()
        {
            var resultadoSuma = 1 + 1;

            Assert.Equal(2, resultadoSuma);
        }


        [Fact]
        public void Jedi_NoNull()
        {
            var jedi1 = new Jedi();

            Assert.NotNull(jedi1);
        }


        [Fact]
        public void Jedi_Name()
        {
            var jedi1 = new Jedi();
            jedi1.Name = "Yoda";

            Assert.NotNull(jedi1);
            Assert.Equal("Yoda", jedi1.Name);
        }


        [Fact]
        public void Jedi_Constructor()
        {
            var jedi1 = new Jedi(4, "Yoda");
            
            Assert.NotNull(jedi1);
            Assert.Equal("Yoda", jedi1.Name);
            Assert.Equal(4, jedi1.JediId);
        }
    }
}