

namespace App.Core.Entidades
{
    public class Alumno: PersonaBase
    {
        public Alumno(string nombre)
           : base(nombre)
        {

        }

        public override string Metodo1()
        {
            throw new NotImplementedException();
        }
    }
}
