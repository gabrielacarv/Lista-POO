using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Aluno
    {
        public string RA;
        public string Nome;
        public decimal NotaProva;
        public decimal NotaTrabalho;
        private decimal NotalFinal;


        public void CalcularMedia()
        {
            NotalFinal = (NotaProva + NotaTrabalho) / 2;
        }

        public bool CalcularNotaFinal()
        {
            if (NotalFinal > 7)
            {
                Console.WriteLine("APROVADO!");
                return true;
            }
            else
            {
                Console.WriteLine($"REPROVADO! Faltam {12 - NotalFinal}!");
                return false;
            }
        }

        public void ImprimirNotaFinal()
        {
            Console.WriteLine($"Nota Final: {NotalFinal}!");
        }

        public void ReceberDados()
        {
            Aluno aluno = new Aluno();

            Console.Write("Digite o RA do aluno: ");
            RA = Console.ReadLine();
            Console.Write("Digite o nome do aluno: ");
            Nome = Console.ReadLine();
            Console.Write("Digite a nota da prova: ");
            NotaProva = decimal.Parse(Console.ReadLine());
            Console.Write("Digite a nota do trabalho: ");
            NotaTrabalho = decimal.Parse(Console.ReadLine());

        }
    }

}
