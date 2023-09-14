using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poomc_ex01
{
    internal class AreaRetangulo
    {
        private double baseR;
        private double alturaR;

        public AreaRetangulo(double baseValor, double alturaValor)
        {
            baseR = baseValor;
            alturaR = alturaValor;
        }
        public double CalcularArea()
        {
            return baseR * alturaR;
        }
    }
}
