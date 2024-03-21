using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities
{
    public class Student: Person
    {
        public Student()
        {

        }

        public Student(string firstName) 
            : base(firstName)
        {

        }

        public override string ToDo()
        {
            //return base.ToDo();

            return $"{base.ToDo()} in Student";
        }

        public string Study() {
            return "ok";
        }

        public string Study(string demo)
        {
            return $"ok {demo}";
        }

        public string Study(bool demo)
        {
            return $"ok {demo}";
        }

    }
}
