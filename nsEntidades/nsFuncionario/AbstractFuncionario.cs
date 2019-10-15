using Aula_14_10_2019.Enums;
using Aula_14_10_2019.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14_10_2019.nsEntidades.nsFuncionario
{
    public abstract class AbstractFuncionario : IFuncionario
    {
        public NivelCarreira Nivel { get; private set; }

        public AbstractFuncionario(NivelCarreira nivelCarreira)
        {
            Nivel = nivelCarreira;
        }

        public abstract decimal GetSalario();
    }
}
