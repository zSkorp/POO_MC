using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poomc_ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular área do quadrado pela diagonal\n");
            Console.Write("Digite o valor da diagonal do quadrado: ");
            double diagonal = Convert.ToDouble(Console.ReadLine());

            AreaQuadrado quadrado = new AreaQuadrado(diagonal);

            double area = quadrado.CalcularArea();
            Console.WriteLine("\nA área do quadrado é: {0}\n", area);
        }
    }
}
