using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradosss
{
    class fahrenheit
    {
        const double fahre = 32.0;
        const double fahre2 = 459.67;
        //const double fahre3 = 9 / 5;

        public double CelsiusFahre(double C)
        {
            double F = 0.0;
            F = ((9 * C) / 5 + fahre);
            return F;
        }

        public double KelvinFahre(double K)
        {
            double F = 0.0;
            F = ((9 * K) / 5 - fahre2);
            return F;
        }
    }
}
