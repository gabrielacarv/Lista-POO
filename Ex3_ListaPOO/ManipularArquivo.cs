using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_ListaPOO
{
    internal class ManipularArquivo
    {
        public string Conteudo;
        public string EnderecoNomeArquivo;

        public bool SalvarDadosArquivo()
        {
            using (StreamWriter writer = new StreamWriter(EnderecoNomeArquivo))
            {
                writer.WriteLine(Conteudo);
            }
            return true;
        }

        public string PesquisarConteudoArquivo(string endereco)
        {
            using (StreamReader reader = new StreamReader(endereco))
            {
                Conteudo = reader.ReadToEnd();
                return Conteudo;
            }
        }
    }
}
