namespace Classroom.Core.Entities.Tests
{
    public class TeacherTest
    {
        [Fact]
        public void prueba_crear_un_profesor_con_nombre()
        {
            var teacher1 = new Teacher() { 
                FirstName = "Lionel"
            };

            Assert.NotNull(teacher1);
            Assert.Equal("Lionel", teacher1.FirstName);

        }


        [Fact]
        public void obtener_nombre_completo_solo_nombre()
        {
            var teacher1 = new Teacher()
            {
                FirstName = "Lionel"
            };

            Assert.NotNull(teacher1);
            Assert.Equal("Lionel", teacher1.FullName);

        }


        [Fact]
        public void obtener_nombre_completo()
        {
            var teacher1 = new Teacher()
            {
                FirstName = "Lionel",
                LastName = "Messi"
            };

            Assert.NotNull(teacher1);
            Assert.Equal("Lionel Messi", teacher1.FullName);

        }
    }
}