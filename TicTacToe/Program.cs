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

Initialize Game
---------------

    Initialize Board with Size
    Initialize Players with Name and PeiceType
    Add Players to List
Start Game
----------

    Continue Game till no one is winner or turn are completed
    Print Board at each step, Enque and Deque Players to maintain turns
    Take input from players and add input to board
    Check winner at each step
    print tie if there is no winner
    
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
