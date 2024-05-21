using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Core.Entities
{
    public class JediResult
    {
        public List<Jedi> Items { get; set; }
        public string Message { get; set; }
        public bool HasError { get; set; }
    }
}
