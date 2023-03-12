using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_ListaPOO
{
    internal class Aluno
    {
        public List<Aluno> listaAlunos = new List<Aluno>();
        public List<Aluno> resultado = new List<Aluno>();

        public string RA;
        public string Nome;
        public decimal NotaProva;
        public decimal NotaTrabalho;
        private decimal NotalFinal;
        private string Resultado;

        public void CalcularMedia(List<Aluno> listaAlunos)
        {
            for(int i = 0; i < listaAlunos.Count; i++)
            {
                NotalFinal = (listaAlunos[i].NotaProva + listaAlunos[i].NotaTrabalho) / 2;
            }
        }

        public bool CalcularNotaFinal()
        {
            Aluno aluno = new Aluno();
            if (NotalFinal > 7)
            {
                aluno.Resultado = "APROVADO!";
                resultado.Add(aluno);
                return true;
            }
            else
            {
                //Console.WriteLine();
                aluno.Resultado = $"REPROVADO! Faltam {12 - NotalFinal}!";
                resultado.Add(aluno);
                return false;
            }
        }


        public void ImprimirNotaFinal(List<Aluno> listaAlunos, List<Aluno> resultado)
        {
            Console.WriteLine("LISTA DE ALUNOS");
            Console.WriteLine("");
            //Console.WriteLine($"Nota Final: {NotalFinal}!");
            for (int i = 0; i < listaAlunos.Count; i++)
            {
                Console.WriteLine($"RA: {listaAlunos[i].RA}");
                Console.WriteLine($"Aluno: {listaAlunos[i].Nome}");               
                Console.WriteLine($"Nota Prova: {listaAlunos[i].NotaProva}");
                Console.WriteLine($"Nota Trabalho: {listaAlunos[i].NotaTrabalho}");
                Console.Write($"Resultado: {resultado[i].Resultado}");
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }

        public void ReceberDados()
        {
            Aluno aluno = new Aluno();

            Console.Write("Digite o RA do aluno: ");
            aluno.RA = Console.ReadLine();
            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite a nota da prova: ");
            aluno.NotaProva = decimal.Parse(Console.ReadLine());
            Console.Write("Digite a nota do trabalho: ");
            aluno.NotaTrabalho = decimal.Parse(Console.ReadLine());
            listaAlunos.Add(aluno);
        }


        public int AdicionarAluno()
        {
            Console.Write("Digite a quantidade de alunos que deseja cadastrar: ");
            int quantAluno = int.Parse(Console.ReadLine());
            return quantAluno;
        }
    }
}
