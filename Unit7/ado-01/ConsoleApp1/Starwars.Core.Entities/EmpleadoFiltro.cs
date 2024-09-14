using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Core.Entities
{
    public class EmpleadoFiltro
    {
        public string TextoABuscar { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
