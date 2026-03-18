using System;

namespace SimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cześć! Jak masz na imię?");
            string name = Console.ReadLine();

            Console.WriteLine($"Miło cię poznać, {name}!");

            Console.WriteLine("Ile masz lat?");
            string ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out int age)){
            Console.WriteLine($"Wow, masz już {age} lat!");
            }
            else{ 
                Console.WriteLine("Błąd: wprowadzono niepoprawny wiek.");
            }

            Console.WriteLine($"Wow, masz już {age} lat!");

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}