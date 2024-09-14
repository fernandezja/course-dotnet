using App.Core.Entidades.Interfaces;

namespace App.Core.Entidades
{
    public abstract class PersonaBase : IConNombre
    {
        public string Nombre { get; private set; }
        public DateTime FechaNacimiento { get; set; }

        public int Edad
        {
            get {
                return CalcularEdad(FechaNacimiento);
            }
        }

        public PersonaBase(string nombre)
        {
            this.Nombre = nombre;
        }


        private int CalcularEdad(DateTime fechaNacimiento)
        {
            if (fechaNacimiento.Year == 1)
            {
                return 0;
            }

            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            if (DateTime.Now.Month < fechaNacimiento.Month 
                || (DateTime.Now.Month == fechaNacimiento.Month 
                && DateTime.Now.Day < fechaNacimiento.Day))
            {
                edad--;
            }

            return edad;
        }

        public override string ToString()
        {
            return $"{Nombre} (Edad {Edad})";
        }

        public abstract string Metodo1();

        public static string Metodo2()
        {
            return "Metodo2";
        }
    }
}