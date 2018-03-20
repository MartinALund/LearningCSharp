using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringShuffler
{
    class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            string word = "Plante";
            string shuffledWord = Shuffle(word);
            string guess;
            int tries = 0;
            Console.WriteLine("Can you guess what this word is? ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(shuffledWord);
            Console.ResetColor();

            while (true)
            {
                Console.WriteLine("Guess a word");
                guess = Console.ReadLine().ToLower();
                tries++;
                if (guess.Equals(word.ToLower()))
                {
                    Console.WriteLine($"Correct! It took you {tries} tries");
                    return;
                }
            }


        }

        private string Shuffle(string str)
        {
            char[] array = str.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array).ToLower(); ;
        }

    }
}