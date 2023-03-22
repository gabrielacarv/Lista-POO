using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Documento doc = new Documento("Exemplo");
            Impressora impressora = new Impressora(doc);

            impressora.SolicitarTexto();
            impressora.SolicitarQuantidadeCopias();
            impressora.Imprimir();
            Console.ReadLine();
        }
    }
}
