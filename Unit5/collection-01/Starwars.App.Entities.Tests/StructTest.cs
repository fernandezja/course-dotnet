using System.Globalization;

namespace Starwars.App.Entities.Tests
{
    public class StructTest
    {
        [Fact]
        public void demo_simple_struct()
        {

            var point1 = new DotNetPoint(1, 1);
            var point2 = new DotNetPoint(2, 2);

            Dummy(point1);
            Dummy(point2);

            Assert.Equal(1, point1.X);
            Assert.Equal(1, point1.Y);

            Assert.Equal(2, point2.X);
            Assert.Equal(2, point2.Y);
        }

        private void Dummy(DotNetPoint point1)
        {
            point1.X = 888;
            point1.Y = 999;
        }

        [Fact]
        public void demo_struct() {

            var point1 = new System.Drawing.Point() { 
                X = 100,
                Y = 200
            };

            var jedi1 = new Jedi();
            jedi1.Move(point1);

            Assert.Equal(100, point1.X);
            Assert.Equal(200, point1.Y);
        }

    }
}