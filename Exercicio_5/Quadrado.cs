using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class Quadrado:Forma
    {
        public double lado;

        public override void CalcularArea()
        {
            Area = lado * lado;
            Console.WriteLine($"Área: {Area}");
        }

        public override void CalcularPerimetro()
        {
            Perimetro = lado * 4;
            Console.WriteLine($"Perímetro: {Perimetro}");
        }
    }
}
