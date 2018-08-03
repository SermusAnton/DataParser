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

    }
}
