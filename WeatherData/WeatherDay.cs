using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherData {
    /// <summary>
    /// http://codekata.com/kata/kata04-data-munging/
    /// В данных вы найдете ежедневные данные о погоде для 
    /// Morristown, Нью-Джерси за июнь 2002 года. 
    /// Загрузите этот текстовый файл, 
    /// затем напишите программу для 
    /// вывода номера дня (столбец один) 
    /// с наименьшим температурным разбросом 
    /// (Максимальная температура-второй столбец, 
    /// минимальная-третий столбец).
    /// </summary>
    public class WeatherDay {

        public int Number { get; set; }

        public double TempMax { get; set; }

        public double TempMin { get; set; }

        public double GetDiffMaxMin() {
            return TempMax - TempMin;
        }
    }
}
