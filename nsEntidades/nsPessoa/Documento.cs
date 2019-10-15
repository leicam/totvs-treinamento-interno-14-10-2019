using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14_10_2019.nsEntidades.nsPessoa
{
    public class Documento
    {
        public string Valor { get; set; }

        public Documento(string documento)
        {
            Valor = documento;
        }

        public bool IsCpf()
        {
            return Valor.Length.Equals(11);
        }

        public bool IsCnpj()
        {
            return Valor.Length.Equals(14);
        }
    }
}
