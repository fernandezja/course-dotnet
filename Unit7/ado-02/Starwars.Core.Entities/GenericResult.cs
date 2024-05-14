using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Core.Entities
{
    public class GenericResult
    {
        public string Message { get; set; }
        public bool IsSuccessful { get; set; }
        public bool HasError { get; set; }
    }
}
