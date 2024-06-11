/*
OBJECTS INVOLVED
----------------

Board
Peice
Player

CLASS REQUIRED
--------------
Board
Peice
PeiceType
Player
PeiceO
PeiceX



*/



namespace TicTacToe;
class Program
{
    static void Main(string[] args)
    {
        TicTacToe game = new TicTacToe();
        game.initializeGame();
        Console.WriteLine($"Game winner is: {game.StartGame()}");
    }
}
