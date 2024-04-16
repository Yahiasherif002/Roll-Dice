internal class Game
{
    private int numberOfPlayers;
    private int numberOfDices;
    private int numberOfRounds;
    private int numberOfSides=6;
    private int pointsToWin;

    public Game(int numberOfPlayers, int numberOfDices, int numberOfRounds, int pointsToWin)
    {
        this.numberOfPlayers = numberOfPlayers;
        this.numberOfDices = numberOfDices;
        this.numberOfRounds = numberOfRounds;
        this.pointsToWin = pointsToWin;
    }
    public void Start()
    {
       Random random=new Random();
        int[] scores =new int[numberOfPlayers];
        for (int round = 0; round < numberOfRounds; round++)
        {
            Console.WriteLine($"Round {round+1}");
            Thread.Sleep(1000);
            for (int player = 0; player < numberOfPlayers; player++)
            {
                int Totalscore = 0;
                for (int k = 0; k < numberOfDices; k++)
                {
                    Console.WriteLine($"Player {player+1} rolling the {k+1} dice");
                    Thread.Sleep(500);
                    Totalscore += random.Next(1, numberOfSides + 1);
                }
                scores[player] += Totalscore;
                Console.WriteLine($"Player {player+1} rolled {Totalscore}");
                Thread.Sleep(1000);
            }
            
        }
        for (int i = 0; i < numberOfPlayers; i++)
        {
            Console.WriteLine($"Player {i + 1} score : {scores[i]}");
            if (scores[i] >= pointsToWin)
            {
                Console.WriteLine($"Player {i + 1} wins!");
                return; // Exit the method if a player wins
            }
        }

        Console.WriteLine("No player reached the winning score");
    }
}