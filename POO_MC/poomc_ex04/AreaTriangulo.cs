using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poomc_ex04
{
    internal class AreaTriangulo
    {
        private double baseTriangulo;
        private double alturaTriangulo;

        public AreaTriangulo(double baseValor, double alturaValor)
        {
            baseTriangulo = baseValor;
            alturaTriangulo = alturaValor;
        }

        public double CalcularArea()
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
    }
}
