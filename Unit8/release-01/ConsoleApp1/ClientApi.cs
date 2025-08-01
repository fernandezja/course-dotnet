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
                var demo = 0;
                //var result = 10 / demo;

                throw new CustomException();

                //throw new ArgumentException("Parametro incorrecto");
            }

            return "Un valor";
        }
    }
}
