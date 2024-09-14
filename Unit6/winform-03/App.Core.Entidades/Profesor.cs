namespace App.Core.Entidades
{
    public class Profesor : PersonaBase
    {
        public Profesor(string nombre) 
            : base(nombre)
        {
            
        }

        public override string Metodo1()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
           
            return $"PROFESOR: {base.ToString()}";
        }

    }
}
