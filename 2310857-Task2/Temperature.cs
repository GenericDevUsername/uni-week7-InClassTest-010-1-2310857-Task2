using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2310857_Task2
{
    internal class Temperature
    {
        // define internal variables + their public readonly counterparts
        // readonly to make sure only Temperature.Set() can be used
        private double celcius;
        public double Celcius
        {
            get { return this.celcius; }
        }
        private double kelvin;
        public double Kelvin
        {
            get { return this.kelvin; }
        }
        private double fahrenheit;
        public double Fahrenheit
        {
            get { return this.fahrenheit; }
        }

        // Class initialisation function
        public Temperature(double temperature = 0, char type = 'C')
        {
            Set(temperature, type);
        }

        public void Set(double temperature = 0, char type = 'C')
        {
            switch (Char.ToLower(type))
            {
                case 'k':
                    KelvinTo(temperature);
                    break;

                case 'f':
                    FahrenheitTo(temperature);
                    break; 

                case 'c':
                    CelciusTo(temperature);
                    break;
            }
        }

        // functions to auto convert Temperature.Set() inputs to all measurements
        private void KelvinTo(double temperature)
        {
            this.kelvin = temperature;
            this.celcius = temperature - 273.15;
            this.fahrenheit = (this.celcius * 9 / 5) + 32;
        }

        private void FahrenheitTo(double temperature)
        {
            this.fahrenheit = temperature;
            this.celcius = (this.fahrenheit - 32) * 5/9;
            this.kelvin = this.celcius + 273.15;

        }
        private void CelciusTo(double temperature)
        {
            this.celcius = temperature;
            this.kelvin = this.celcius + 273.15;
            this.fahrenheit = (this.celcius * 9 / 5) + 32;
        }

    }
}
