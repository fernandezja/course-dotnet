using System.Drawing;
using System.Globalization;

namespace Starwars.Core.Entities.Tests
{
    public class StringTest
    {
        private const string COURSE_NET = "Course .NET";





        [Fact]
        public void String_Concat()
        {
            const string NET = ".NET";

            //var demo = ".NET";
            var demo = new System.Text.StringBuilder();

            for (int i = 0; i < 1000; i++)
            {
                //demo = demo + ".NET";
                demo.Append(i.ToString());
                demo.Append(NET);
            }

            Assert.NotEmpty(demo.ToString());
        }


        [Fact]
        public void test1()
        {

            Assert.Equal(11, COURSE_NET.Length);
            Assert.Equal(7, COURSE_NET.IndexOf("."));
            Assert.Equal("NET", COURSE_NET.Substring(startIndex: 8, length: 3));

            Assert.Equal(2, COURSE_NET.Split(" ").Length);
            Assert.Equal("Course", COURSE_NET.Split(" ")[0]);
            Assert.Equal(".NET", COURSE_NET.Split(" ")[1]);

            Assert.Equal('C', COURSE_NET[0]);
            Assert.Equal('.', COURSE_NET[7]);
        }




    }
}