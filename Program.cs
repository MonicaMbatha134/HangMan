using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Super";
            int maxLives = 7;
            int currentLives = maxLives;

            bool win = false;
            List<char> guessedLetter = new List<char>();
            while (currentLives > 0 && !win)
            {
                foreach (char c in word)
                {
                    if (guessedLetter.Contains(c))
                        Console.Write(c);

                    else
                        Console.Write("_");

                }
                Console.WriteLine("\n Please guess a letter");
                Console.WriteLine(currentLives + "/" + maxLives + "lives remaining");

                char guess = Convert.ToChar(Console.ReadLine());

                if (word.Contains(guess) && !guessedLetter.Contains(guess))

                    Console.WriteLine("Correct!");

                else
                {
                    Console.WriteLine("Incorrect guess!");
                    currentLives--;
                }
                guessedLetter.Add(guess);

                bool wordComplete = true;
                foreach (char c in word)
                    if (!guessedLetter.Contains(c))
                        wordComplete = false;

                if (win)
                    Console.WriteLine("Congratulations, you win!");
                else
                    Console.WriteLine("You lose...");


            }
        }
    }
}
