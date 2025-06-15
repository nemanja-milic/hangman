using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class GuesserWord
    {
        private char Letter;

        public void Guess(List<char>missedLetters, List<char> guessedLetters)
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter a letter to guess:");

            string word = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(word) || missedLetters.Contains(word[0]) ||guessedLetters.Contains(word[0]))
            {
                Console.WriteLine("Please enter a valid letter that has not been guessed or missed yet.");
                word = Console.ReadLine();
            }
            this.Letter = word[0];
        }

        public char GetLetter()
        {
            return this.Letter;
        }

    }
}
