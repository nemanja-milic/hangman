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
        public void Start()
        {
            Console.WriteLine("Game started!");
            Console.WriteLine("Type the guessing the word");
         
            this.WordChooser.TypeWord();
            Console.WriteLine(this.WordChooser.Word);
            this.RenderSkeleton();
            this.StartEngine();
        }

        public void RenderSkeleton()
        {
            Console.WriteLine("Rendering game skeleton...");
        }

        public void StartEngine()
        {
            // for(string.length(this.WordChooser.word))
            // string res = this.GuesserWord.guess();
            // if(string.contains(res) printout
            Console.WriteLine("Starting game engine...");
            // Here you would implement the logic to start the game engine,
            // such as initializing the game state, setting up the word to guess,
            // and preparing for player input.
        }

    }

}
