using Aula_14_10_2019.Enums;
using Aula_14_10_2019.Exceptions;
using Aula_14_10_2019.nsEntidades.nsFuncionario;
using Aula_14_10_2019.nsEntidades.nsPessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14_10_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoas = new List<PessoaFisica>();
            
            pessoas.Add(new PessoaFisica(new Documento("08887953945"), new Analista(NivelCarreira.Pleno), "Juliano"));
            pessoas.Add(new PessoaFisica(new Documento("08887953945"), new Gerente(NivelCarreira.Senior), "Vitor"));

            pessoas.ForEach(x => { Console.WriteLine($"{x.Nome} {x.GetSalario()} {x.Funcionario.Nivel}"); });

            Console.ReadLine();
        }
    }
}
