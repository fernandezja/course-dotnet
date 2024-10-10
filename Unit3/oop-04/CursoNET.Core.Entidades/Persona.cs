


namespace CursoNET.Core.Entidades;


public class Persona: IDisposable
{
    public string _nombre;

    public string Nombre
    {
        get {
            //acciones....

            return _nombre; 
        }
        private set { 
            _nombre = value; 
        }
    }

    public string Apellido { get; private set; }
    public string NombreCompleto {
        get {
            return $"{Nombre} {Apellido}";
        }
    }

    public DateTime FechaNacimiento { get; set; }

    public Persona()
    {
    
    }

    public Persona(string nombre, string apellido)
    {
        //_nombre = nombre;
        Nombre = nombre;
        Apellido = apellido;
    }

    public int Edad()
    {
       return DateTime.Now.Year - FechaNacimiento.Year;
    }

    public void CambiarNombre(string nuevoNombre)
    {
        Nombre = nuevoNombre;
    }

    public void Dispose() 
    {
        //acciones del destructor
    }
}