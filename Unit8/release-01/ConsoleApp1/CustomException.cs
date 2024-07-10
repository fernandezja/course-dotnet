using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomException: ApplicationException
    {
        public override string Message => "Demo CustomException Message";
    }
}
