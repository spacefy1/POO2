namespace SerVivo
{

    internal class Program {

        static void Main(string[] args)
        {
            Console.WriteLine("== SER VIVO ==");

            SerVivo sv = new();
            sv.Nascer();
            sv.Cresce();
            sv.Morrer();

            Console.WriteLine("== ANIMAL ==");
            Animal an = new();
            an.Mover();
            an.Respirar();
            an.Nascer();

        }
        
    
    }

}
