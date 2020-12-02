using System;
using System.Threading;
using System.Collections.Generic;

namespace VStest
{
    class Program
    {
        static void Main(string[] args)
        {
            //START GAME
            Console.WriteLine("GALGJE");
            Thread.Sleep(1000);
            Console.WriteLine(" ");
            Console.WriteLine("Kies een woord:");
            string word = Console.ReadLine();
            //VARS
            int kansen = 9;
            var guesses = new List<string>();
            //WHILE LOOP
            while (kansen > 0)
            {
                //GUESS THE WORD
                Console.WriteLine(" ");
                Console.WriteLine("Raad het woord:");
                string guess = Console.ReadLine();
                //EQUAL
                if (guess == word)
                {
                    Console.WriteLine("Woord is goed geraden");
                    break;
                }
                //GUESSED EARLIER
                else if(guesses.Contains(guess))
                {
                    kansen -= 1;
                    Console.WriteLine(" ");
                    Console.WriteLine("Woord is eerder al (geprobeerd te) raden");
                    Console.WriteLine($"U heeft nog {kansen} kansen over.");
                }
                //GUESS IS INSIDE WORD
                //WRONG
                else
                {
                    kansen -= 1;
                    guesses.Add(guess);
                    Console.WriteLine(" ");
                    Console.WriteLine("Fout, probeer het nog eens");
                    Console.WriteLine($"U heeft nog {kansen} kansen over.");
                }
            }
        }
    }
}