
namespace CursoNET.Core.Entidades;

public class DemoClass
{
    private string _nombre;
    

    public string Nombre 
    {
        get { 
            return _nombre;
        }

        set { 
            _nombre = value;
        }
    }


    public string Apellido { get; private set; }

    public string Saludar()
    {
       return $"Hola, {Nombre}";
    }

    public override bool Equals(object? other)
    {
        if (other == null || GetType() != other.GetType())
        {
            return false;
        }

        if(other.GetType() == typeof(DemoClass))
        {

            var otherDemo = (DemoClass)other;

            return Nombre == otherDemo.Nombre 
                    && Apellido == otherDemo.Apellido;
        }

        return false;
    }

    public DemoClass()
    {
        
    }

    public DemoClass(string nombre)
    {        
        Nombre = nombre;
    }

    public DemoClass(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
    }

    public Tuple<string, string> Metodo1()
    {
        return Tuple.Create("Metodo1", Apellido );
    }

}

