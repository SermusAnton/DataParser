using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherData {
    public class WeatherMonth:  IEnumerable<WeatherDay>  {
        private List<WeatherDay> days = new List<WeatherDay>();
        public void Add(WeatherDay value) {
            days.Add(value);
        }

        public IEnumerator<WeatherDay> GetEnumerator() {
            return days.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return days.GetEnumerator();
        }

        public int GetNumerDayMinDiff() {
            //double minDiff = days.Min(m => m.GetDiffMaxMin());
            //return days
            //    .Where(w=>w.GetDiffMaxMin()==minDiff)              
            //    .Select(s => s.Number).First();
            int number = 0;
            int minDiff= int.MaxValue;
            foreach (var day in days) {
                if (day.GetDiffMaxMin() <= minDiff) {
                    number = day.Number;
                }                    
            }
            return number;
        }
    }
}
