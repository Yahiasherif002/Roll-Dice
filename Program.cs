internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Welcome to the Roll-Dice game!");
        Console.WriteLine("Press any key to start the game...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Enter the number of players: ");
        int numberOfPlayers = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of dices: ");
        int numberOfDices = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of rounds: ");
        int numberOfRounds = int.Parse(Console.ReadLine());
       
        Console.WriteLine("Enter the number of points to win: ");
        int pointsToWin = int.Parse(Console.ReadLine());
        Console.Clear();
        Game game = new Game(numberOfPlayers, numberOfDices, numberOfRounds,  pointsToWin);
        game.Start();
        Console.WriteLine("Do you want to play again? (Y/N)");
        string answer = Console.ReadLine().ToLower();
        if (answer == "y")
        {
            Main(args);
        }
        else
        {
            Console.WriteLine("Thank you for playing!");
        }


    }
}
