using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temp t1 = new Temp();

            t1.converge();

            //DEVO CORRIGIR ESSE CODIGO E TROCAR A CLASSE TEMP E BOTAR NA MAIN

            Console.WriteLine("Pressione qualquer tecla para sair ");
            Console.ReadKey();
        }
    }
}
