using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities
{
    public class TvLed
    {

        //public string Print(Teacher teacher)
        //{           
        //    return $"SHOW {teacher.Name}";
        //}

        //public string Print(Student student)
        //{
        //    return $"SHOW {student.Name}";
        //}

        public string Print(IName objectWithName)
        {
            return $"SHOW {objectWithName.Name}";
        }
    }
}
