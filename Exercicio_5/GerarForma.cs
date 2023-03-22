using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class GerarForma
    {
        public void SolicitarForma()
        {
            bool validacao = true;
            Quadrado quadrado = new Quadrado();           
            Hexagono hexagono = new Hexagono();
            Triangulo triangulo = new Triangulo();
            Circunferencia circunferencia = new Circunferencia();

            while (validacao == true)
            {
                Console.WriteLine("Selecione a forma geometrica que deseja saber a ÁREA e o PERÍMETRO!");
                Console.WriteLine("1 - Quadrado");
                Console.WriteLine("2 - Hexágono");
                Console.WriteLine("3 - Triângulo");
                Console.WriteLine("4 - Circunferência");
                Console.WriteLine("5 - Sair");
                Console.Write("Digite o número correspondete da forma que deseja: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Selecionou QUADRADO!");
                        Console.Write("Insira o valor de um dos lados do quadrado: ");
                        quadrado.lado = double.Parse(Console.ReadLine());
                        quadrado.CalcularArea();
                        quadrado.CalcularPerimetro();
                        Console.WriteLine();
                        Console.WriteLine();
                        validacao = true;
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Selecionou HEXÁGONO!");
                        Console.Write("Insira o valor de um dos lados do hexágono: ");
                        hexagono.lado = double.Parse(Console.ReadLine());
                        hexagono.CalcularArea();
                        hexagono.CalcularPerimetro();
                        Console.WriteLine();
                        Console.WriteLine();
                        validacao = true;
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Selecionou TRIÂNGULO!");
                        Console.Write("Insira o valor do 1º lado do triângulo: ");
                        triangulo.ladoA = double.Parse(Console.ReadLine());
                        Console.Write("Insira o valor do 2º lado do triângulo: ");
                        triangulo.ladoB = double.Parse(Console.ReadLine());
                        Console.Write("Insira o valor do 3º lado do triângulo: ");
                        triangulo.ladoC = double.Parse(Console.ReadLine());
                        Console.Write("Insira a altura do triângulo: ");
                        triangulo.Altura = double.Parse(Console.ReadLine());
                        Console.Write("Insira a base do triângulo: ");
                        triangulo.Base = double.Parse(Console.ReadLine());
                        triangulo.CalcularArea();
                        triangulo.CalcularPerimetro();
                        Console.WriteLine();
                        Console.WriteLine();
                        validacao = true;
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Selecionou CIRCUNFERÊNCIA!");
                        Console.Write("Insira o valor do raio da circunferencia: ");
                        circunferencia.raio = double.Parse(Console.ReadLine());
                        circunferencia.CalcularArea();
                        circunferencia.CalcularPerimetro();
                        Console.WriteLine();
                        Console.WriteLine();
                        validacao = true;
                        break;

                    case 5:
                        return;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Opção Inválida");
                        Console.WriteLine();
                        Console.WriteLine();
                        validacao = true;
                        break;
                }              
            }
            
            Console.ReadLine();
        }
    }
}
