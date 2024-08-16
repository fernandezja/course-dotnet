namespace Starwars.Core.Entities
{
    public interface IJedi
    {
        string Id { get; }
        string Name { get; set; }

        bool Equals(Jedi? other);
    }
}