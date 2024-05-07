namespace Starwars.Core.Entities
{
    public class Jedi
    {
        public int JediId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} ({JediId})";
        }
    }
}
