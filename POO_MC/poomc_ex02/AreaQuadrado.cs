using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poomc_ex02
{
    internal class AreaQuadrado
    {
        private double lado;

        public AreaQuadrado(double ladoValor)
        {
            lado = ladoValor;
        }

        public double CalcularArea()
        {
            return lado * lado;
        }
    }
}
