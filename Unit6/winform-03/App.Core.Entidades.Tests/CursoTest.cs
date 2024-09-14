namespace App.Core.Entidades.Tests
{
    public class CursoTest
    {
        [Fact]
        public void TestDemo()
        {
           var resultado = 1 + 3;

           Assert.Equal(4, resultado);
        }

        [Fact]
        public void UnCursoDebeTenerUnProfesor()
        {
            var curso = new Curso();
            curso.Profesor = new Profesor("Profesor 1");

            Assert.NotNull(curso.Profesor);
        }

        [Fact]
        public void UnCursoConNombre()
        {
            var curso = new Curso(".NET");
            
            Assert.Equal(".NET", curso.Nombre);
        }

        [Fact]
        public void UnCursoCreadoNoTieneAlumnos()
        {
            var curso = new Curso();

            Assert.Equal(0, curso.Alumnos.Count);
        }


        [Fact]
        public void UnCursoSePuedeASignarUnAlumno()
        {
            var curso = new Curso();
            curso.Agregar(new Alumno("Alumno 1"));

            Assert.Equal(1, curso.Alumnos.Count);
        }

        [Fact]
        public void UnCursoSePuedeASignar100Alumnos()
        {
            var curso = new Curso();

            for (int i = 0; i < 100; i++)
            {
                curso.Agregar(new Alumno($"Alumno {i}"));
            }
            

            Assert.Equal(100, curso.Alumnos.Count);
        }
    }
}