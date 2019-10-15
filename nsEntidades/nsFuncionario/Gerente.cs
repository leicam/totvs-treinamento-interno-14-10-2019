using Aula_14_10_2019.Enums;
using Aula_14_10_2019.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14_10_2019.nsEntidades.nsFuncionario
{
    public class Gerente : AbstractFuncionario
    {
        public Gerente(NivelCarreira nivelCarreira) : base(nivelCarreira) { }

        public override decimal GetSalario()
        {
            return 7000;
        }
    }
}
