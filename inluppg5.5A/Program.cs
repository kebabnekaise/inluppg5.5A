using System;

namespace inluppg5_5A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] answers = new string[]
            {
               "Kanske",
               "Njao",
               "Vet inte",
               "Fråga någon annan",
               "...",
               "Möjligt men inte helt säkert",
               "Va?",
               "Joaoaooanjae",
               "Det beror på",
               "Det går inte att svara på det",
            };

            Random rnd = new Random();
            while (true)
            {
                int index = rnd.Next(answers.Length);
                Console.WriteLine("Skriv en fråga till den magiska kulan. (a)vsluta");
                string quit = Console.ReadLine();
                if(quit == "a")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(answers[index]);
                }
                Console.WriteLine();
            }
        }
    }
}