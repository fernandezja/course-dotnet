namespace Starwars.Core.Entities.Tests
{
    public class PersonTest
    {
        [Fact]
        public void Person_Crear_Instancia_Not_Null()
        {
            var p1 = new Person();

            Assert.NotNull(p1);
        }


        [Fact]
        public void Person_Propiedadades_Test1()
        {
            var p1 = new Person(personId: 123);
            //p1.PersonId = 1;
            p1.Name = "Luke";
            p1.Lastname = "Skywalker";
            

            Assert.NotNull(p1);
            Assert.Equal(123, p1.PersonId);
            Assert.Equal("Luke", p1.Name);
            Assert.Equal("Skywalker", p1.Lastname);
        }

        [Fact]
        public void Person_Propiedadades_Test2()
        {
            var p1 = new Person(personId: 123)
            {
                Name = "Luke",
                Lastname = "Skywalker"
            };


            Assert.NotNull(p1);
            Assert.Equal(123, p1.PersonId);
            Assert.Equal("Luke", p1.Name);
            Assert.Equal("Skywalker", p1.Lastname);
        }

        [Fact]
        public void Person_Propiedadades_Test3()
        {
            Person p1 = new (personId: 123)
            {
                Name = "Luke",
                Lastname = "Skywalker"
            };


            Assert.NotNull(p1);
            Assert.Equal(123, p1.PersonId);
            Assert.Equal("Luke", p1.Name);
            Assert.Equal("Skywalker", p1.Lastname);
        }

        [Fact]
        public void Saludar_Test1()
        {
            var p1 = new Person();
            p1.Name = "Luke";
            p1.Lastname = "Skywalker";

            Assert.Equal("Hello Luke!", p1.Saludar());
        }

        [Fact]
        public void Saludar_Test2()
        {
            var p1 = new Person();
            p1.Name = "Leia";

            Assert.Equal("Hello Leia!", p1.Saludar());
        }
    }
}