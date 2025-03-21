using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.NET.Utils.Test
{
    public class StringTest
    {

        [Fact]
        public void Concatenar1()
        {
            
            var name = "Curso .NET";
            var curso = "";

            for (int i = 0; i < 10000; i++)
            {
                curso = curso + name;
            }


            Assert.NotNull(curso);
        }



        [Fact]
        public void Concatenar2()
        {

            var name = "Curso .NET";
            var curso = new System.Text.StringBuilder();

            for (int i = 0; i < 1000000; i++)
            {
                //curso = curso + name;
                curso.Append(name);
            }


            Assert.NotNull(curso);
        }

    }
}
