using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities
{
    public class Course
    {
        public string Title { get; set; }
        public Teacher Teacher { get; set; }
    }
}
