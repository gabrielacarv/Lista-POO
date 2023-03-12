using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_ListaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManipularArquivo manipularArquivo = new ManipularArquivo();

            manipularArquivo.EnderecoNomeArquivo = @"C:\Users\gabri\Documents\SIF\3º PERÍODO\arquivo.txt";
            manipularArquivo.Conteudo = "Olá, isso é um teste!";

            Console.WriteLine(manipularArquivo.SalvarDadosArquivo());
            string ResultadoPesquisa = manipularArquivo.PesquisarConteudoArquivo(@"C:\Users\gabri\Documents\SIF\3º PERÍODO\arquivo.txt");
            Console.WriteLine(ResultadoPesquisa);
            Console.ReadLine();
        }
    }
}
