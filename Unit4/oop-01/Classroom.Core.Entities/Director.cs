using Classroom.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities
{
    public  class Director
    {
        //public string Call(Teacher teacher)
        //{
        //    return $"Call to {teacher.LastName}";
        //}

        //public string Call(Student student)
        //{
        //    return $"Call to {student.LastName}";
        //}


        //public string Call(Person person)
        //{
        //    return $"Call to {person.LastName}";
        //}

        public string Call(IWithLastName objectWithLastName)
        {
            return $"Call to {objectWithLastName.LastName}";
        }
    }
}
