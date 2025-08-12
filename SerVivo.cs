using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerVivo
{
    internal class SerVivo
    {
        public int tamanho { get; set; }

        public void Nascer() => Console.WriteLine("O Ser vivo nasceu!!");

        public void Cresce() => Console.WriteLine("Ser vivo: Cresceu()");

        public void Morrer() => Console.WriteLine("Ser vivo: Morreu()");
    }
}
