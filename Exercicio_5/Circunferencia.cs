using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class Circunferencia:Forma
    {
        public double raio;

        public override void CaclcularArea()
        {
            Area = Math.PI * (raio * raio);
            Console.WriteLine($"Área: {Area}");
        }

        public override void CalcularPerimetro()
        {
            Perimetro = 2 * Math.PI * raio;
            Console.WriteLine($"Área: {Perimetro}");
        }
    }
}
