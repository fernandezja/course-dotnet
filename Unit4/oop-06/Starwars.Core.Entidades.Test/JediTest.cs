namespace Starwars.Core.Entidades.Test
{
    public class JediTest
    {
        [Fact]
        public void DeberiaTenerUnNombreElJedi()
        {

            var jedi = new Jedi { 
                JediId = 1,
                Name = "Luke Skywalker" 
            };



            Assert.Equal("Luke Skywalker", jedi.Name);
        }
    }
}
