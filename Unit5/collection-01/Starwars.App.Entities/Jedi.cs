using System.Drawing;
using System.Net.NetworkInformation;

namespace Starwars.App.Entities
{
    public class Jedi
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Move(Point point)
        {
            point.X = point.X + 10;
            point.Y = point.Y + 10;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{Name} ({Id})";
        }
    }
}
