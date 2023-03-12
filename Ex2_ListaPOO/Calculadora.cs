using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_ListaPOO
{
    public class Calculadora
    {
        Calculo calculo = new Calculo();
        public void LerValores()
        {
            Console.Write("Digite o valor de A: ");
            calculo.ValorA = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            calculo.ValorB = double.Parse(Console.ReadLine());
        }

        public void ExecutarCalculadora()
        {
            int verificador = 0;
            do
            {
                Console.WriteLine("             ---------- MENU ----------");
                Console.WriteLine("             |    1 - SOMA            |");
                Console.WriteLine("             |    2 - SUBTRAÇÃO       |");
                Console.WriteLine("             |    3 - MULTIPLICAÇÃO   |");
                Console.WriteLine("             |    4 - SOMA GERAL      |");
                Console.WriteLine("             |    5 - MAIOR VALOR     |");
                Console.WriteLine("             --------------------------");
                Console.Write("Digite o número correposndente com a opção que deseja: ");
                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("");
                switch (opcao)
                {
                    case 1:
                        LerValores();
                        calculo.CalcularSoma();
                        Console.WriteLine($"A soma dos números inseridos é {calculo.ImprimirResultado()}");
                        verificador = 0;
                        break;

                    case 2:
                        LerValores();
                        calculo.CalcularSubtracao();
                        Console.WriteLine($"A subtração dos números inseridos é {calculo.ImprimirResultado()}");
                        verificador = 0;
                        break;

                    case 3:
                        LerValores();
                        calculo.CalcularMultiplicacao();
                        Console.WriteLine($"A multiplicação dos números inseridos é {calculo.ImprimirResultado()}");
                        verificador = 0;
                        break;

                    case 4:
                        LerValores();
                        calculo.SomarGeral(5);
                        Console.WriteLine($"A soma dos números inseridos mais o valor padrão de 5 é {calculo.ImprimirResultado()}");
                        verificador = 0;
                        break;

                    case 5:
                        LerValores();
                        Console.WriteLine($"O maior valor inserido é {calculo.RetornarMaior()}");
                        verificador = 0;
                        break;

                    default:
                        Console.WriteLine("OPÇÃO INVÁLIDA!");
                        verificador = 1;
                        break;
                }
            } while (verificador == 1);
           
            
            Console.ReadLine();
        }
    }
}
