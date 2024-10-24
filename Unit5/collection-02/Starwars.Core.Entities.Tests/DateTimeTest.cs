using Starwars.Core.Entities.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starwars.Core.Entities.Tests
{
    public class DateTimeTest
    {
       

        [Fact]
        public void Instance_Min_Value_DateTime()
        {
            var d1 = new DateTime();

            Assert.Equal(1, d1.Day);
            Assert.Equal(1, d1.Month);
            Assert.Equal(1, d1.Year);

        }

        [Fact]
        public void Now_DateTime()
        {
            var now = DateTime.Now;

            Assert.NotNull(now);
            Assert.True(now.Day > 0);

        }

        [Fact]
        public void MaxValue_DateTime()
        {
            var dateMax = DateTime.MaxValue;

            Assert.Equal(31, dateMax.Day);
            Assert.Equal(12, dateMax.Month);
            Assert.Equal(9999, dateMax.Year);

        }

        [Fact]
        public void constructor_DateTime()
        {
            var d1 = new DateTime(2024, 10, 24, 15, 31, 0);

            Assert.Equal(24, d1.Day);
            Assert.Equal(10, d1.Month);
            Assert.Equal(2024, d1.Year);
            Assert.Equal(15, d1.Hour);
            Assert.Equal(31, d1.Minute);
            Assert.Equal(0, d1.Second);
            Assert.Equal(DayOfWeek.Thursday, d1.DayOfWeek);

        }


        [Fact]
        public void ToStringShortAndLong_DateTime()
        {
            var d1 = new DateTime(2024, 10, 24, 15, 31, 0);

            var result1 = d1.ToShortDateString();
            var result2 = d1.ToShortTimeString();
            var result3 = d1.ToLongDateString();
            var result4 = d1.ToLongTimeString();

            Assert.Equal("24/10/2024", result1);
            Assert.Equal("15:31", result2);
            Assert.Equal("jueves, 24 de octubre de 2024", result3);
            Assert.Equal("15:31:00", result4);
            Assert.Equal(DayOfWeek.Thursday , d1.DayOfWeek);

        }


        [Fact]
        public void ToString_Custom_DateTime()
        {
            var d1 = new DateTime(2024, 10, 24, 15, 31, 0);

            var result1 = d1.ToString("yy ** MM ** dd");
            var result2 = d1.ToString("yy ** MMM ** dd");
            var result3 = d1.ToString("yy ** MMMM ** dd");

            Assert.Equal("24 ** 10 ** 24", result1);
            Assert.Equal("24 ** oct. ** 24", result2);
            Assert.Equal("24 ** octubre ** 24", result3);
            Assert.Equal(DayOfWeek.Thursday, d1.DayOfWeek);

        }


        [Fact]
        public void AddMinutos_DateTime()
        {
            var d1 = new DateTime(2024, 8, 16, 16, 01, 0);
            var d2 = d1.AddMinutes(30);
           
            //new DateTime(2024, 8, 16, 16, 23, 0);

            var result = d2.Subtract(d1); //d2 - d1;

            Assert.Equal(30, result.TotalMinutes);
            Assert.Equal(30*60, result.TotalSeconds);

        }


        [Fact]
        public void CultureInfo_DateTime()
        {
            var d1 = new DateTime(2024, 10, 24, 15, 31, 0);

            var enUSCulture = new System.Globalization.CultureInfo("en-US");
            var frFRCulture = new System.Globalization.CultureInfo("fr-FR");

            Assert.Equal("24/10/2024 15:31:00", d1.ToString());
            Assert.Equal("10/24/2024 3:31:00 PM", d1.ToString(enUSCulture));
            Assert.Equal("24/10/2024 15:31:00", d1.ToString(frFRCulture));
        }


        [Fact]
        public void UTC_DateTime()
        {
            var d1 = new DateTime(2024, 10, 24, 15, 31, 0);

            Assert.Equal(18, d1.ToUniversalTime().Hour);
            Assert.Equal(31, d1.ToUniversalTime().Minute);

        }


        [Fact]
        public void Parse_DateTime()
        {
            var dateString1 = "24/10/2024 15:31:00";

            var esARCulture = new CultureInfo("es-AR");

            var d1 = DateTime.Parse(dateString1, esARCulture);

            Assert.Equal(24, d1.Day);
            Assert.Equal(10, d1.Month);
            Assert.Equal(2024, d1.Year);
            Assert.Equal(15, d1.Hour);
            Assert.Equal(31, d1.Minute);
            Assert.Equal(0, d1.Second);
            Assert.Equal(DayOfWeek.Thursday, d1.DayOfWeek);


            var dateString2 = "2024-10-24T15:31";

            var d2 = DateTime.Parse(dateString2,
                                    CultureInfo.InvariantCulture,
                                    System.Globalization.DateTimeStyles.None);

            Assert.Equal(24, d1.Day);
            Assert.Equal(10, d1.Month);
            Assert.Equal(2024, d1.Year);
            Assert.Equal(15, d1.Hour);
            Assert.Equal(31, d1.Minute);
            Assert.Equal(0, d1.Second);            
            Assert.Equal(DayOfWeek.Thursday, d1.DayOfWeek);

        }

    }
}
