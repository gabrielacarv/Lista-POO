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

        public override void CaclcularArea()
        {
            Area = Base * Altura * (1/2);
        }

        public override void CalcularPerimetro()
        {
            Perimetro = ladoA + ladoB + ladoC;
        }
    }
}
