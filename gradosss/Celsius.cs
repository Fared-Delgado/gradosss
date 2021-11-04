using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradosss
{
    public class Celsius
    {
        const double celsius = 273.15;
        const double celsius2 = 32.0;
        // const double celsius3 = 5 / 9;
        public double KelvinCelsius(double K)
        {
            double C = 0.0;
            C = K - celsius;
            return C;
        }

        public double FahrenCelsius(double F)
        {
            double C = 0.0;
            C = (5 * (F - celsius2)) / 9;
            return C;
        }
    }
}

