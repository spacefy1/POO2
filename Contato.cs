using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Contato
    {

        public string Nome { get; set; }
        public string NumeroTelefone { get; set; } 

        public string Apelido { get; set; }

        public int QauntoMeDeve { get; set; }

        public Contato(string nome, string numeroTelefonico, string apelido, int qauntoMeDeve)
        {
            Nome = nome;
            NumeroTelefone = numeroTelefonico;
            Apelido = apelido;
            QauntoMeDeve = qauntoMeDeve;
        }

        
    }
}
