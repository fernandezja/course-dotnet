using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name { get; set; }
			

        private string _lastName;

		public string LastName
		{
			get { 
				return _lastName; 
			}
			set 
			{ 
				//Step1: Log into DB

				//Step2:
				_lastName = value; 
			}
		}


		public int Age { get; set; } = 0;


		public string FullName 
		{
			get 
			{
				return $"{Name} {LastName}";
			}
		}


		public string FullName2() {
            //return Name + " " + _lastName;
            return Name + " " + LastName;
        }



    }
}
