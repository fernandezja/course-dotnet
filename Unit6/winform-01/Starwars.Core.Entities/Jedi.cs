namespace Starwars.Core.Entities;

public class Jedi: IEquatable<Jedi>
{
    public string Name {get; set;}
    public int Age {get; set; }

    public bool Equals(Jedi? other)
    {
        if (other is null) {
            return false;
        }

        return other.Name == this.Name;
    }
}
