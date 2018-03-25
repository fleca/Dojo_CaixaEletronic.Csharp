using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Exceptions
{
    public class ContaIdenticaException : Exception
    {
        public ContaIdenticaException()
            : base("Não pode transferir para a mesma conta!")
        {
        }
    }
}
