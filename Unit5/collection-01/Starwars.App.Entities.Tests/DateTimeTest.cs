using System.Globalization;

namespace Starwars.App.Entities.Tests
{
    public class DateTimeTest
    {
        [Fact]
        public void Now_Test()
        {
            var now = DateTime.Now;

            Assert.NotNull(now);
        }



        [Fact]
        public void Initial_Datetime()
        {
            var d1 = new DateTime();

            Assert.Equal(1, d1.Year);
            Assert.Equal(1, d1.Month);
            Assert.Equal(1, d1.Day);
            Assert.Equal(DayOfWeek.Monday, d1.DayOfWeek);
        }





        [Fact]
        public void datetime_subtract_result_timeSpan()
        {
            var d1 = new DateTime(2024, 6, 7, 18, 0, 0);
            var d2 = new DateTime(2024, 6, 7, 18, 22, 0);

            TimeSpan result = d2.Subtract(d1);
            //TimeSpan result = d2 - d1;


            Assert.Equal(22, result.TotalMinutes);
            Assert.Equal(1320, result.TotalSeconds);
            Assert.Equal(1320000, result.TotalMilliseconds);
        }


        [Fact]
        public void datetime_addMinutes()
        {
            var d1 = new DateTime(2024, 3, 22, 18, 0, 0);
            var d2 = d1.AddMinutes(28);

            var result = d2.Subtract(d1);

            Assert.Equal(28, result.TotalMinutes);
            Assert.Equal(1680, result.TotalSeconds);
            Assert.Equal(1680000, result.TotalMilliseconds);
        }


        [Fact]
        public void datetime_toString()
        {
            var d1 = new DateTime(2024, 6, 7, 18, 28, 0);

            Assert.Equal("7/6/2024 18:28:00", d1.ToString());

            Assert.Equal("07/06/2024 18:28:00", d1.ToString("dd/MM/yyyy HH:mm:ss"));
        }


        [Fact]
        public void datetime_toString_cultura()
        {
            var d1 = new DateTime(2024, 6, 7, 18, 28, 0);

            var enUSCulture = new CultureInfo("en-us");
            var frFRCulture = new CultureInfo("fr-FR");

            Assert.Equal("7/6/2024 18:28:00", d1.ToString());
            Assert.Equal("6/7/2024 6:28:00 PM", d1.ToString(enUSCulture));
            Assert.Equal("07/06/2024 18:28:00", d1.ToString(frFRCulture));
        }


        [Fact]
        public void datetime_toString_custom()
        {
            var d1 = new DateTime(2024, 3, 22, 18, 28, 0);
;
            Assert.Equal("viernes, 22 de marzo de 2024", d1.ToLongDateString());

            Assert.Equal("22 de marzo de 2024", d1.ToString("dd \\de MMMM \\de yyyy"));
        }


        [Fact]
        public void datetime_toString_utc()
        {
            var d1 = new DateTime(2024, 3, 22, 18, 28, 0);
            
            Assert.Equal(21, d1.ToUniversalTime().Hour);
            Assert.Equal(28, d1.ToUniversalTime().Minute);
        }


        [Fact]
        public void datetime_parse()
        {
            var dateString1 = "07/06/2024 18:39";                   
            var esArCulture = new CultureInfo("es-ar");
            var d1 = DateTime.Parse(dateString1, esArCulture);

            Assert.Equal(2024, d1.Year);
            Assert.Equal(6, d1.Month);
            Assert.Equal(7, d1.Day);
            Assert.Equal(18, d1.Hour);
            Assert.Equal(39, d1.Minute);



            var dateString2 = "2024-06-07T18:39"; 

            var d2 = DateTime.Parse(dateString2, 
                                    CultureInfo.InvariantCulture, 
                                    System.Globalization.DateTimeStyles.None);

            Assert.Equal(2024, d2.Year);
            Assert.Equal(6, d2.Month);
            Assert.Equal(7, d2.Day);
            Assert.Equal(18, d2.Hour);
            Assert.Equal(39, d2.Minute);

        }
    
    }
}