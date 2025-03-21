

namespace CursoNET.Core.Entidades;


public class Persona: IDisposable
{
    public int PersonaId { get; private set; }

    public string Nombre { get; set; }


    private string _apellido;
    public string Apellido
    {
        get
        {
            return _apellido;
        }
        set
        {
            _apellido = value;
            //Accion
        }
    }

    public string GetApellido() {
        return _apellido;
    }
    public void SetApellido(string value)
    {
        _apellido = value;
    }


    public Persona()
    {
        PersonaId = 10;
    }

    public Persona(string nombre, string apellido)
    {
        PersonaId = 10;
        Nombre = nombre;
        Apellido = apellido;
    }

    public bool EsIgual(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        
        var personaParaComparar = (Persona)obj;

        var esIgual = (Nombre == personaParaComparar.Nombre
                      && Apellido == personaParaComparar.Apellido);

        return esIgual;
    }

    public void Dispose()
    {
        //Acciones para liberar recursos
    }


    //Calcular la edad en base a al FechaDeNacimiento
    public int Edad
    {
        get
        {
            var edad = DateTime.Today.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }
    }


    public string NombreCompleto
    {
        get
        {
            return $"{Nombre} {Apellido}";
        }
    }

    public DateTime FechaNacimiento { get; set; }
}