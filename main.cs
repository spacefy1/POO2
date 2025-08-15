using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExPOO
{
    class Program
    {
      static int Main(string[] args)

        {
            {
                Pessoa pessoa1 = new Pessoa(12);
                Pessoa p2 = new Pessoa(0);

                pessoa1.grupo();
                p2.grupo();

            }
            return 0;
        }

    }  
        
      
}
    