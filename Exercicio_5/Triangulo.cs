using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class Triangulo:Forma
    {
        public double ladoA;
        public double ladoB;
        public double ladoC;
        public double Base;
        public double Altura;

        public override void CalcularArea()
        {
            Area = Base * Altura * (1/2);
            Console.WriteLine($"Área: {Area}");
        }

        public override void CalcularPerimetro()
        {
            Perimetro = ladoA + ladoB + ladoC;
            Console.WriteLine($"Perímetro: {Perimetro}");
        }
    }
}
