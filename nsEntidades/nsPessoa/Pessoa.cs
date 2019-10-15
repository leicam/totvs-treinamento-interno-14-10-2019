using Aula_14_10_2019.Interfaces;
using Aula_14_10_2019.nsEntidades.nsFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14_10_2019.nsEntidades.nsPessoa
{
    public abstract class Pessoa
    {
        public Documento Documento { get; private set; }
        public AbstractFuncionario Funcionario { get; private set; }

        public Pessoa(Documento documento, AbstractFuncionario funcionario)
        {
            Documento = documento;
            Funcionario = funcionario;
        }

        public decimal GetSalario()
        {
            return Funcionario.GetSalario();
        }
    }
}
