using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class Hexagono:Forma
    {
        public double lado;

        public override void CaclcularArea()
        {
            Area = (3 * (lado * lado) * Math.Sqrt(3)) / 2;
            Console.WriteLine($"Área: {Area}");
        }

        public override void CalcularPerimetro()
        {
            Perimetro = lado * 6;
            Console.WriteLine($"Área: {Perimetro}");
        }
    }
}
