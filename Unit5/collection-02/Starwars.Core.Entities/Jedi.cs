namespace Starwars.Core.Entities;

public class Jedi : IEquatable<Jedi>, IJedi
{
    private DateTime _birthDate;

    public DateTime BirthDate
    {
        get { return _birthDate; }
        set { _birthDate = value; }
    }



    public string Id { get; private set; }

    public string Name { get; set; }

    public bool Equals(Jedi? other)
    {
        if (other is null)
        {
            return false;
        }

        return other.Name == this.Name;
    }
}
