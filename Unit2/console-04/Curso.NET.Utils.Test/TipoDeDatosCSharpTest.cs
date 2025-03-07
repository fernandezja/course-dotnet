using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.NET.Utils.Test
{
    public class TipoDeDatosCSharpTest
    {

        [Fact]
        public void DebeCrearUnEntero()
        {
            
            Int32 numero1 = 1;
            int numero2 = 1;

            
            Assert.Equal(numero1, numero2);
        }


        [Fact]
        public void UsoDeVar()
        {

            var name = 1;

            Assert.Equal("System.Int32", name.GetType().ToString());
        }


        [Fact]
        public void UsoDelFor()
        {
            var resultado = 0;
            for (int i = 0; i < 10; i++)
            {
                resultado += i;
            }

            Assert.Equal(45, resultado);
        }


        [Fact]
        public void UsoDelForConBreak()
        {
            var resultado = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                resultado += i;
            }

            Assert.Equal(10, resultado);
        }


        [Fact]
        public void UsoDelForConContinue()
        {
            var resultado = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                resultado += i;
            }

            Assert.Equal(40, resultado);
        }
    }
}
