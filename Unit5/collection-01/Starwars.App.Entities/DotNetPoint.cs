using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.App.Entities
{
    public struct DotNetPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public DotNetPoint()
        {
            
        }

        public DotNetPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string Demo() {
            return $"{X} {Y}";
        }
    }
}
