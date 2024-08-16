using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities
{
    public static class Formatter
    {
        public static string FormatName(INameAndLastName itemWithName)
        {
            return $"{itemWithName.Name} {itemWithName.LastName}";
        }
    }
}
