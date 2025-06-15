using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Printer
    {
        private string word;

        private readonly string[] Stages = new string[]
    {
@"
 +---+
 |   |
     |
     |
     |
     |
=========",

@"
 +---+
 |   |
 O   |
     |
     |
     |
=========",

@"
 +---+
 |   |
 O   |
 |   |
     |
     |
=========",

@"
 +---+
 |   |
 O   |
/|   |
     |
     |
=========",

@"
 +---+
 |   |
 O   |
/|\  |
     |
     |
=========",

@"
 +---+
 |   |
 O   |
/|\  |
/    |
     |
=========",

@"
 +---+
 |   |
 O   |
/|\  |
/ \  |
     |
========="
    };

        public Printer(string word)
        {
            this.word = word;
        }

        private void Skeleton(int wrongGuesses)
        {
            wrongGuesses--; // because of the position in array
            Console.WriteLine(Stages[wrongGuesses]);
        }

        public void Print(char letter, List<char>missedLettes, List<char> guessedLetters,int remaningAttempts, bool missOrHit)
        {
            if(!missOrHit) { 
                this.Skeleton(missedLettes.Count());
            }
            this.PrintDashesOfWord(guessedLetters);
            // print first skeleton 
            // print the dashes of the word
            // missed letters 
            // number of remaining attempts
        }

        public void PrintDashesOfWord(List<char> guessedLetters)
        {
            char[] output = new char[this.word.Length];
            for(int i = 0; i < this.word.Length; i++)
            {
                if (guessedLetters.Contains(this.word[i]))
                {
                    output[i] = this.word[i];
                }
                else
                {
                    output[i] = '-';
                }
            }
            Console.WriteLine(output);
        }
    }
}
