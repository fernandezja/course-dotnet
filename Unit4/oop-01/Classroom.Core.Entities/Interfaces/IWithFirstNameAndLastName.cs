using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Interfaces
{
    public interface IWithFirstNameAndLastName
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
