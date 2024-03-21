using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities
{
    public abstract class PersonBase
    {

        public virtual int AgeCalc(DateOnly birthdate)
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var age = today.Year - birthdate.Year;
            if (birthdate > today.AddYears(-age)) age--;
            return age;
        }

    }
}
