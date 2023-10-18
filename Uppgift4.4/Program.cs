using System;
namespace Uppgift4_4
{
    class Program
    {
        static void Main(string[] args) 
        {
            string svar;
            int tal1;
            int tal2;
            bool cont = true;

            do
            {
                Console.WriteLine("Välj ett av följande alternativ.\n1. Subtrahera ett tal med ett annat\n2. Dividera ett tal med ett annat\n3. Avsluta programmet");
                svar = Console.ReadLine();

                switch (svar)
                {
                    case "1":
                        Console.WriteLine("Skriv in 2 tal på varsin linje som ska subtraheras");
                        tal1 = int.Parse(Console.ReadLine());
                        tal2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Svaret är {tal1-tal2}.");
                        break;

                    case "2":
                        Console.WriteLine("Skriv in 2 tal på varsin linje som ska divideras");
                        tal1 = int.Parse(Console.ReadLine());
                        tal2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Svaret är {tal1 / tal2}.");
                        break;

                    case "3":
                        cont = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val!");
                        break;
                }
            } while (cont);
        }
    }
}