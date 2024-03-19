using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Tests
{
    public class PrinterTest
    {
        [Fact]
        public void print_iWithFullName()
        {
            var teacher1 = new Teacher()
            {
                FirstName = "Lionel"
            };

            Assert.Equal("Lionel", Printer.Print(teacher1));

        }

    }
}
