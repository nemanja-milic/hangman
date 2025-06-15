using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Hangman
{
    class WordChooser
    {
        public string Word { get; set; }
        public void TypeWord()
        {
            string word = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(word))
            {
                word = Console.ReadLine();
            }
            this.Word = word;
        }

        public List<int> PositionsOfLetter(char letter)
        {
            List<int> positions = new List<int>();
            for (int i = 0; i < this.Word.Length; i++)
            {
                if (this.Word[i] == letter)
                {
                    positions.Add(i);
                    break;
                }
            }
            return positions;
        }
    }
}
