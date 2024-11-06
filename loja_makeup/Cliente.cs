using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_makeup
{
    internal class Cliente
    {
      
            public int CodCliente { get; set; }
            public string Nome { get; set; }
            public string Sobrenome { get; set; }
            public string Cidade { get; set; }
            public string Cpf { get; set; }
            public string Estado { get; set; }
            public string Telefone { get; set; }



        public Cliente(int codCliente, string nome,
                string sobrenome, string cidade, string cpf, string estado, string telefone) : this(nome, sobrenome, cidade, cpf, estado, telefone)
            {
                CodCliente = codCliente;
            }

            public Cliente(string nome, string sobrenome, string cidade, string cpf, string estado, string telefone)
            {
                Nome = Nome;
                Sobrenome = Sobrenome;
                Cidade = Cidade;
                Cpf = Cpf;
                Estado = Estado;
                Telefone = Telefone;
            }
        }
}
