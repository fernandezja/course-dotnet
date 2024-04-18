using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Core.Entities.Extensions
{
    public static class JediExtensions
    {
        public static string ExtensionDemo(this Jedi jedi) {
            return $"{jedi.Name} Extension";
        }

        public static string ExtensionDemo2(this Jedi jedi, int value)
        {
            return $"{jedi.Name} Extension2 [{value}]";
        }
    }
}
