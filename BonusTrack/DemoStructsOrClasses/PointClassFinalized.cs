using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStructsOrClasses
{
    public class PointClassFinalized : PointClass
    {
        public PointClassFinalized(int x, int y) : base(x, y)
        {
        }
        ~PointClassFinalized()
        {
            // how will the finalizer affect performance?
        }
    }
}
