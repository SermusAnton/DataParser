using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WeatherData;

namespace Test {
    [TestFixture]
    public class WeatherDataTest {

        [Test]
        public void A0_InitWeatherDay() {
            WeatherDay weatherDay = new WeatherDay();
            Assert.IsTrue(weatherDay!= null);
        }

        [Test]
        public void A1_GetDiffMaxMin() {
            WeatherDay weatherDay = new WeatherDay();
            weatherDay.Number = 1;
            weatherDay.TempMax = 34.4;
            weatherDay.TempMin = 15.5;
            Assert.AreEqual(weatherDay.GetDiffMaxMin(),  18.9);
        }
        [Test]
        public void B0_InitWeatherMonth() {
            WeatherMonth weatherMonth = new WeatherMonth();
            Assert.IsTrue(weatherMonth != null);
        }

        /// <summary>
        /// Проверяем добавление элемента в коллекцию
        /// </summary>
        [Test]
        public void B1_WeatherMonthAdd() {
            WeatherDay weatherDay = new WeatherDay();
            weatherDay.Number = 1;
            weatherDay.TempMax = 34.4;
            weatherDay.TempMin = 15.5;

            List<WeatherDay> days = new List<WeatherDay>();
            days.Add(weatherDay);

            WeatherMonth weatherMonth = new WeatherMonth();
            weatherMonth.Add(weatherDay);
            CollectionAssert.AreEqual(weatherMonth, days);
        }

        /// <summary>
        /// Проверяем выбор минимального значения за месяц
        /// </summary>
        [Test]
        public void B2_WeatherMonthAdd() {
            WeatherDay weatherDay1 = new WeatherDay();
            weatherDay1.Number = 1;
            weatherDay1.TempMax = 34.4;
            weatherDay1.TempMin = 15.5;

            WeatherDay weatherDay2 = new WeatherDay();
            weatherDay2.Number = 2;
            weatherDay2.TempMax = 34.4;
            weatherDay2.TempMin = 34.1;

            WeatherMonth weatherMonth = new WeatherMonth();
            weatherMonth.Add(weatherDay1);
            weatherMonth.Add(weatherDay2);

            Assert.AreEqual(weatherMonth.GetNumerDayMinDiff(), 2);
        }

    }
}
