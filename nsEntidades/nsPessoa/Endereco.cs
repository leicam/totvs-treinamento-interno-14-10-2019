using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14_10_2019.nsEntidades.nsPessoa
{
    public class Endereco
    {
        public string Logradouro { get; private set; }
        public bool IsPrincipal { get; private set; }

        public Endereco(string logradouro, bool isPrincipal = false)
        {
            Logradouro = logradouro;
            IsPrincipal = isPrincipal;
        }
    }
}
