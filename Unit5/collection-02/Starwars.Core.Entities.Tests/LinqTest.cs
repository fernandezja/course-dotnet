using Starwars.Core.Entities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Core.Entities.Tests
{
    public class LinqTest
    {
        private List<Jedi> _jedis;

        public LinqTest()
        {
            _jedis = Generate(1000);
        }



        [Fact]
        public void Linq_intro()
        {

            //Inferencia de Tipo
            var demoInferenciaTipo = 100;

            var a = demoInferenciaTipo;


        //Tipo de dato Anonimo
        // Inicializadores de Objetos
        //https://learn.microsoft.com/es-es/dotnet/visual-basic/programming-guide/language-features/objects-and-classes/object-initializers-named-and-anonymous-types
            var demo2 = new
            {
                Name = "Yoda",
                Age = 355
            };

            Assert.Equal("Yoda", demo2.Name);


            //MEtodos extensores
            var jedi = new Jedi() { 
                Name = "Yoda"
            };
            
            Assert.Equal("Yoda Extension", jedi.ExtensionDemo());
            Assert.Equal("Yoda Extension2 [123]", jedi.ExtensionDemo2(value: 123));


            //Funciones anonimas > Lamda
            //https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/operators/lambda-expressions
        }


        [Fact]
        public void Linq_query_simple() { 

            //With 99 into "name"

            //for (int i = 0; i < _jedis.Count; i++)
            //{
            //    var jedi = _jedis[i];

            //    if (jedi.Name.Contains("99"))
            //    {

            //    }
            //}


            var query = from j in _jedis
                        where j.Name.Contains("99") 
                        select j;

            var query2 = _jedis
                            .Where(j => j.Name.Contains("99"))
                            .Select(j => j);

            var count = query.Count();

            var existAny = query.Any();


            Assert.Equal(19, count);
            Assert.True(existAny);

        }


        [Fact]
        public void Linq_query_simple_2()
        {

            //With 99 into "name"
            var query = from j in _jedis
                        where j.Name.Contains("99")
                        select new { 
                            j.Name,
                            j.BirthDate
                            }; //TIP


            var count = query.Count();
            var existAny = query.Any();


            Assert.Equal(19, count);
            Assert.True(existAny);

        }


        [Fact]
        public void Linq_query_simple_3()
        {

            //With 99 into "name"
            var query = from j in _jedis
                        where j.Name.Contains("99")
                        select j.Name;

            
            var count = query.Count();
            var existAny = query.Any();


            Assert.Equal(19, count);
            Assert.True(existAny);

            var nameList = query.ToList();
            Assert.Equal("Jedi 99", nameList[0]);
            Assert.Equal("Jedi 999", nameList[18]);

        }



        [Fact]
        public void Linq_query_simple_4()
        {

            //With 99 into "name"
            var query = from j in _jedis
                        where j.Name.Contains("99")
                        select new { 
                            Nombre = j.Name,
                            CompletoCompleto = $"{j.Name} {j.Name}"
                        };


            var count = query.Count();
            var existAny = query.Any();


            Assert.Equal(19, count);
            Assert.True(existAny);

            var nameList = query.ToList();
            Assert.Equal("Jedi 99", nameList[0].Nombre);
            Assert.Equal("Jedi 99 Jedi 99", nameList[0].CompletoCompleto);

        }


        [Fact]
        public void Linq_query_simple_5()
        {

            //With 99 into "name"
            //var query = from j in _jedis
            //            where j.Name.Contains("99")
            //            select new
            //            {
            //                Nombre = j.Name,
            //                CompletoCompleto = $"{j.Name} {j.Name}"
            //            };

            var query = _jedis
                            .Where(j => j.Name.Contains("99"))
                            .OrderBy(j => j.Name)
                            .Select(j => new { Nombre = j.Name,
                                                CompletoCompleto = $"{j.Name} {j.Name}"});


            var count = query.Count();
            var existAny = query.Any();


            Assert.Equal(19, count);
            Assert.True(existAny);

            var nameList = query.ToList();
            Assert.Equal("Jedi 199", nameList[0].Nombre);
            Assert.Equal("Jedi 199 Jedi 199", nameList[0].CompletoCompleto);

        }



        private static List<Jedi> Generate(int count)
        {
            var jedis = new List<Jedi>();

            for (int i = 1; i <= count; i++)
            {
                var jedi = new Jedi();
                jedi.Name = $"Jedi {i}";

                jedis.Add(jedi);
            }

            return jedis;
        }
    }
}
