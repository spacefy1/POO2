using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Temp
    {
        public double temp { get; set; }
        public int choice { get; set; }

        public int choice2 { get; set; }
        public Temp()
        {
            Console.Write("Como voce quer escrever a temperatura \nDigite: \n1- Para Celsius \n2-Fahrenheit \n3- Kelvin \n"); choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a temperatura: "); temp = Double.Parse(Console.ReadLine());


        }

        public double converge()
        {
            double fluc = 0;
            

            if (choice == 1)
            {
                Console.Write("Qual é a forma que voce deseja converter: \n1- Celsius para Fahrenheit \n2- Celsius para Kelvin ");
                choice2 = int.Parse(Console.ReadLine());
                if (choice2 == 1)
                {
                    fluc = temp * 1.8 + 32;
                    return fluc;
                    Console.WriteLine("Aqui está a temperatura em Fahrenheit:", +fluc);
                }
                else if (choice2 == 2)
                {
                    fluc = temp + 273.15;
                    return fluc;
                    Console.WriteLine("Aqui está a temperatura em Kelvin:", + fluc);
                }
            } 
            else if (choice == 2)
            {
                fluc = (temp - 32) / 1.8;
                return fluc;
                Console.WriteLine("Aqui está a temperatura de Fahrenheit para Celsius: C", + fluc);
            } 
            else if (choice == 3)
            {
                fluc = temp - 273.15;
                return fluc;
                Console.WriteLine("Aqui está a temperatura de Kelvin para Celsius:", +fluc);
            }
            else
            {
                Console.WriteLine("Voce digitou uma escolha errada, repita");
            }

            return fluc;
        }
    }
}
