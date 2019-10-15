using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14_10_2019.Enums
{
    public enum NivelCarreira
    {
        [Description("Sênior")]
        Senior = 1,

        [Description("Pleno")]
        Pleno = 2,

        [Description("Junior")]
        Junior = 3,
    }
}
