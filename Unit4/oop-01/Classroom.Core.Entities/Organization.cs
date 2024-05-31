using Classroom.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities
{
    public class Organization: IWithLastName
    {
        public string LastName { get; set; }
    }
}
