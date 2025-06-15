using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Game
    {
        protected WordChooser WordChooser = new WordChooser();
        protected GuesserWord GuesserWord = new GuesserWord();
        protected Printer Printer;
        protected readonly int MaxAttempts = 6;
        protected int NumberOfAttempts = 0;
        protected List<char> MissedLetters = new List<char>();
        protected List<char> GuessedLetters = new List<char>();

        public Game()
        {
            Console.WriteLine("Game started!");
            Console.WriteLine("Type the guessing the word");

            this.WordChooser.TypeWord();
            this.Printer = new Printer(this.WordChooser.Word);
            this.StartEngine();
        }

        public void StartEngine()
        {
            Console.WriteLine("Game engine has started");
            for(int i = 0; i < this.MaxAttempts; i++)
            {
                this.GuesserWord.Guess(this.MissedLetters, this.GuessedLetters);
                this.NumberOfAttempts++;
                bool missOrHit = true;
                if (this.WordChooser.PositionsOfLetter(this.GuesserWord.GetLetter()).Count() == 0)
                {
                    Console.WriteLine("Letter not found, try again.");
                    this.MissedLetters.Add(this.GuesserWord.GetLetter());
                    missOrHit = false;
                }
                else
                {
                    Console.WriteLine("Letter found!");
                    this.GuessedLetters.Add(this.GuesserWord.GetLetter());
                }
                this.Printer.Print(
                    this.GuesserWord.GetLetter(),
                    this.MissedLetters,
                    this.GuessedLetters,
                    this.MaxAttempts - this.NumberOfAttempts,
                    missOrHit
                );
            }
        }
    }

}
