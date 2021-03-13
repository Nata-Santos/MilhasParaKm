using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            string medida;
            double milhas, km;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Entre com a medida (em milhas):");
            Console.WriteLine("-------------------------------");
            Console.ResetColor();
            
            medida = Console.ReadLine();
            milhas = Convert.ToDouble(medida);
            km = milhas * 1.609;
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---Equivalente---");
            Console.WriteLine($"{km} Km");
            Console.ResetColor();





            

        }
    }
}
