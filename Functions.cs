using System;

namespace TD_6_A2
{
    public class Functions
    {
        public static ConsoleKey PromptDirection()
        {
            Console.WriteLine("Veuillez entrer une direction en utilisant les flèches du clavier : ");
            return Console.ReadKey().Key;
        }
    }
}