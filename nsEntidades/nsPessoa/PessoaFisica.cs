using Aula_14_10_2019.Interfaces;
using Aula_14_10_2019.nsEntidades.nsFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14_10_2019.nsEntidades.nsPessoa
{
    public class PessoaFisica : Pessoa
    {
        public string Nome { get; private set; }
        public List<Endereco> Enderecos { get; private set; } = new List<Endereco>();

        public PessoaFisica(Documento documento, AbstractFuncionario funcionario, string nome) : base(documento, funcionario) 
        {
            Nome = nome;
        }

        public void AdicionarEndereco(Endereco endereco)
        {
            Enderecos.Add(endereco);
        }

        public void AdicionarEndereco(List<Endereco> enderecos)
        {
            Enderecos.AddRange(enderecos);
        }

        public void PrintEnderecoPrincipal()
        {
            Enderecos.ForEach(x =>
            {
                if (x.IsPrincipal)
                    Console.WriteLine(x.Logradouro);
            });
        }
    }
}
