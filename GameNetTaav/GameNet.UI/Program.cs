using GameNet.GuessNumber;
using GameNet.GuessWord;
namespace GameNet.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var gamenet = new Gamenet();
            Console.WriteLine("Chois game");
            Console.WriteLine("1- Guess Number Games");
            Console.WriteLine("2- Guess Words Games");
            Console.WriteLine("3- Sudoko");
            string game = Console.ReadLine();
            if (game == "1") {
                var guessNumberGame = new GuessNumberGames();
                gamenet.BuyGame(guessNumberGame);
                gamenet.PlayGame();
            }
            else if (game == "2")
            {
                var guessNumberGame = new GuessWordGame();
                gamenet.BuyGame(guessNumberGame);
                gamenet.PlayGame();
            }

        }
    }
}
