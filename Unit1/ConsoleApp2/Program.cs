//import 
using Starwars.Core.Entities;
using SCE = Starwars.Core.Entities;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var p1 = new Starwars.Core.Entities.Person();
            var p2 = new Person();
            var p3 = new SCE.Person();

            bool b1 = true;
            Boolean b2 = true;

            int num1 = 1;
            System.Int32 num2 = 1;


        }
    }
}
