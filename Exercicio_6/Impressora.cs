using System;

namespace Exercicio_6
{
    internal class Impressora
    {
        private int qtdeCopia=1;
        private Documento documento;

        public Impressora(Documento documento)
        {
            this.documento = documento;
            qtdeCopia=1;
        }

        public void Imprimir()
        {
            for(int i = 0; i < qtdeCopia; i++)
            {
                Console.WriteLine(documento.texto);
            }                  
        }
        public void SolicitarTexto()
        {
            Console.WriteLine("Digite o texto a ser impresso:");
            string texto = Console.ReadLine();
            documento = new Documento(texto);

        }
        public void SolicitarQuantidadeCopias()
        {
            Console.WriteLine("Digite a quantidade de cópias:");
            int quantidade = int.Parse(Console.ReadLine());
            qtdeCopia = quantidade;
        }
    }
}
