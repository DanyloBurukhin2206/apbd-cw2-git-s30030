using System;

namespace SimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = AskName();
            Console.WriteLine($"Miło cię poznać, {name}!");

            int? age = AskAge();

            if (age != null)
            {
                Console.WriteLine($"Wow, masz już {age} lat!");

                if (StatisticsHelper.IsAdult(age.Value))
                {
                    Console.WriteLine("Jesteś pełnoletni.");
                }
                else
                {
                    Console.WriteLine("Nie jesteś pełnoletni.");
                }
            }

            Console.WriteLine("Naciśnij dowolny klawisz, aby zamknąć aplikację...");
            Console.ReadKey();
        }

        static string AskName()
        {
            Console.WriteLine("Cześć! Jak masz na imię?");
            return Console.ReadLine() ?? "Nieznany";
        }

        static int? AskAge()
        {
            Console.WriteLine("Ile masz lat?");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                return age;
            }

            Console.WriteLine("Błąd: wiek musi być liczbą całkowitą.");
            return null;
        }
    }

    class StatisticsHelper
    {
        public static bool IsAdult(int age)
        {
            return age >= 18;
        }
    }
}