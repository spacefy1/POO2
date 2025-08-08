using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AgendaTelefonica
    {
        public Dictionary<string, Contato> Agenda { get; set; }


        public AgendaTelefonica()
        {
            Agenda = new Dictionary<string, Contato>;
        }

        public void adicionar(Contato contato)
        {
            Agenda.Add(contato.Nome, contato);
        }

        public Contato BuscarContato(string nome)
        {
            return Agenda.ContainsKey(nome) ? Agenda[nome] : null;
        }

        public int QtdContatos()
        {
            return Agenda.Count;
        }
    }
}
