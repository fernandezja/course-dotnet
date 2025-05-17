using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStructsOrClasses
{
    public struct PointStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
        public float Y { get; set; }


        public PointStruct(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
