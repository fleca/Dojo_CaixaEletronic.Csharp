using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.ArquivoTexto
{
    public class LeitorArquivo
    {
        public LeitorArquivo()
        {
        }

        public IList<string> LerLinhasArquivo(string caminhoArquivo)
        {
            var retorno = new List<string>();
            StreamReader sr = null;
            try
            {
                using (sr = new StreamReader(caminhoArquivo))
                {
                    var linha = sr.ReadLine();                    
                    while (linha != null)
                    {
                        retorno.Add(linha);
                        linha = sr.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: tratar exception
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

            return retorno;
        }
    }
}
