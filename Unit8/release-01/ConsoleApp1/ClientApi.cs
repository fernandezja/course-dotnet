using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ClientApi
    {
        public string GetValue(bool hasError) 
        {
            if (hasError)
            {
                throw new CustomException();
            }

            return "Un valor";
        }
    }
}
