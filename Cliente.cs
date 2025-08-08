using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Cliente
    {
        private string nome { get; set; }

        private string endereco { get; set; }

        private string cpf { get; set; }

        public Cliente(string nome, string endereco, string cpf)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.cpf = cpf;
        }


    }
}
