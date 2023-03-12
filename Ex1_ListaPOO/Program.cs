using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            aluno.ReceberDados();
            aluno.CalcularMedia();
            aluno.CalcularNotaFinal();
            aluno.ImprimirNotaFinal();

            Console.ReadLine();
        }
    }
}
