using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Tests
{
    public class IVACalcTest
    {
        [Fact]
        public void IVACalctTest1()
        {
            //var ivaCalc = new IVACalc();
            
            var result = IVACalc.CalculateIVA(100, 21);

            Assert.Equal(21, result);

        }
    }
}
