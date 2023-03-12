using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_ListaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();           

            int quantAluno = aluno.AdicionarAluno();

            Console.Clear();

            for (int i = 0; i < quantAluno; i++)
            {
                Console.WriteLine($"Cadastrando aluno {i+1} de {quantAluno}!");
                aluno.ReceberDados();
                aluno.CalcularMedia(aluno.listaAlunos);
                aluno.CalcularNotaFinal();
                Console.Clear();
                
            }
            aluno.ImprimirNotaFinal(aluno.listaAlunos, aluno.resultado);

            Console.ReadLine();
        }      
    }
}
