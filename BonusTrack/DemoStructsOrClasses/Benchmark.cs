using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStructsOrClasses
{
    public class Benchmark
    {
        public const int Iterations = 10000000;

        // performance benchmark with finalized classes
        public bool MeasureTestA()
        {
            var list = new PointClassFinalized[Iterations];
            for (int i = 0; i < Iterations; i++)
            {
                list[i] = new PointClassFinalized(i, i);
            }
            return true;
        }

        // performance benchmark with normal classes
        public bool MeasureTestB()
        {
            var list = new PointClass[Iterations];
            for (int i = 0; i < Iterations; i++)
            {
                list[i] = new PointClass(i, i);
            }
            return true;
        }

        // performance benchmark with structs
        public bool MeasureTestC()
        {
            var list = new PointStruct[Iterations];
            for (int i = 0; i < Iterations; i++)
            {
                list[i] = new PointStruct(i, i);
            }
            return true;
        }
    }
}
