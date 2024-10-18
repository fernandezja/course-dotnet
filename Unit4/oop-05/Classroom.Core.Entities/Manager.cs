using Classroom.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities
{
    public static class Manager
    {
        /*
        public string Method1(Student student)
        {
            return $"Hi {student.Name}";
        }

        public string Method1(Teacher teacher)
        {
            return $"Hi {teacher.Name}";
        }
        */

        //public string Method1(Person person)
        //{
        //    return $"Hi {person.Name}";
        //}

        public static string Method1(IName objectWithName)
        {
            return $"Hi {objectWithName.Name}";
        }

    }
}
