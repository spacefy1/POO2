using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerVivo
{
    internal class Animal : SerVivo
    {
        public void Mover() => Console.WriteLine("O animal está se mexendo");

        public void Respirar() => Console.WriteLine("Animal: Respirar()");

 
    }
}
