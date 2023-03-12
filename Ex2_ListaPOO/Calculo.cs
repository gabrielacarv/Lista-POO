using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_ListaPOO
{
    public class Calculo
    {
        public double Resultado;
        public double ValorA;
        public double ValorB;

        public void CalcularSoma()
        {
            Resultado = ValorA + ValorB;
        }

        public void CalcularSubtracao()
        {
            Resultado = ValorA - ValorB;
        }

        public void CalcularMultiplicacao()
        {
            Resultado = ValorA * ValorB;
        }
        public double RetornarMaior()
        {
            if (ValorA > ValorB)
            {
                return ValorA;
            }
            else
            {
                return ValorB;
            }
            
        }
        public double SomarGeral( double valor)
        {
            Resultado = ValorA + ValorB + valor;
            return Resultado;
        }
        public double ImprimirResultado()
        {           
            return Resultado;
        }
    }
}
