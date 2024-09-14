
using App.Core.Entidades.Interfaces;

namespace App.Core.Entidades
{
    public class Curso: IConNombre
    {
        public string Nombre { get; private set; }
        public Profesor Profesor { get; set; }
        public List<Alumno> Alumnos { get; set; }

        public Curso()
        {
            Alumnos = new List<Alumno>();
        }

        public Curso(string nombre)
        {
            Nombre = nombre;
            Alumnos = new List<Alumno>();
        }

        public void Agregar(Alumno alumno)
        {
            Alumnos.Add(alumno);
        }
    }
}
