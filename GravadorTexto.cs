using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.ArquivoTexto
{
    public class GravadorArquivo
    {
        public GravadorArquivo()
        {

        }

        public bool EscreverArquivo(string nomeArquivo, string linha)
        {
            try
            {
                using (var writer = new StreamWriter(nomeArquivo, true /*adicionar novas coisas, false reescreveria o arquivo*/, Encoding.UTF8))
                {
                    writer.WriteLine(linha);
                }
                return true;
            }
            catch (Exception ex)
            {
                //TODO: tratar exception
                return false;
            }
        }
    }
}