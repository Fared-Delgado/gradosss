using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradosss
{
    class Kelvin
    {
        const double kelvin = 273.15;
        const double kelvin2 = 459.67;
        const double kelvin3 = 5 / 9;
        public double CelsiusKelvin(double C)
        {
            double K = 0.0;
            K = C + kelvin;
            return K;
        }

        public double FahrenKelvin(double F)
        {
            double K = 0.0;
            K = (5 * (F + kelvin2)) / 9;
            return K;
        }

    }
}
