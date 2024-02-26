using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Wheater
    {
        public decimal Temperature {  get; private set; }
        public decimal Pressure { get; private set; }
        public decimal Humidity { get; private set; }
        public DateTime DateTime { get; private set; }

        public Wheater(decimal temperature, decimal pressure, decimal humidity)
        {
            Temperature = temperature;
            Pressure = pressure;
            Humidity = humidity;
            DateTime = DateTime.Now;
        }
    }
}
