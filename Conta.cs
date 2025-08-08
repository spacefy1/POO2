using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Conta
    {
        public double Saldo { get; set; }

        private int numero { get; set; }

        public bool Sacar(double valor)
        {
            if(valor == 0)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }

        public void Deposita(double valor)
        {
            if()
        }
    }
}
