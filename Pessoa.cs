using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPOO
{
    internal class Pessoa
    {
        private int idade {  get; set; }

        public Pessoa(int idade) => this.idade = idade;


        public void grupo()
        {
            if (this.idade > 0 && this.idade <= 15)
            {
                Console.WriteLine("Faixa Etaria: A");
            } 
            else if(this.idade > 15 && this.idade <= 30)
            {
                Console.WriteLine("Faixa Etaria: B");
            }
            else if (this.idade > 30 && this.idade <= 45)
            {
                Console.WriteLine("Faixa Etaria: C");
            }
            else if (this.idade > 45 && this.idade <= 60)
            {
                Console.WriteLine("Faixa Etaria: D");
            }
            else if (this.idade >= 61)
            {
                Console.WriteLine("Faixa Etaria: E");
            }

            foreach (var node in Process.GetProcessesByName("node"))
            {   
                if (this.idade <= 0)
                {
                    node.Kill();
                }
                
            }
            
                            
        }
    }
}
