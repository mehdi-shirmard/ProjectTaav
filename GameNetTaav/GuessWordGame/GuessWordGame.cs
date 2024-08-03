using GameNet.Infora;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameNet.GuessWord
{
    public class GuessWordGame : Game
    { 
        protected override string Name { get; set; } = "Taav Guess word";

        private readonly string _word = "Random.";
        private int _guessCount = 0;


        string[] words = { "apple", "banana", "cherry", "date", "elderberry" };
        Random random = new Random();

        string guess = "";
        int attempts = 0;
        string wordToGuess;
        public GuessWordGame()
        {
            wordToGuess = words[random.Next(words.Length)];
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

        protected override void Play()
        {
            bool isGuessCorrect = false;
            if (!isGuessCorrect)
            {

                guess = GetWord();
                
                if (guess == wordToGuess)
                {
                    Console.WriteLine($"Congradulation the guess word  was ${wordToGuess} !!!");
                    isGuessCorrect = true;
                }
                else 
                {
                    Play();
                }
            }


        }
        private string GetWord()
        {
            Console.WriteLine("enter your guess :");
            return Console.ReadLine();
   
        }


    }
}
