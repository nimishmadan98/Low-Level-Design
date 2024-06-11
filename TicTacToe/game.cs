using System.Collections.Generic;
namespace TicTacToe;

public class TicTacToe
{
    Board gameBoard;
    LinkedList<Player> players;

    public void initializeGame(){
        gameBoard = new Board(3);
        players = new LinkedList<Player>();
        Peice peiceX = new PeiceX(PeiceType.X);
        Player playerX = new Player(peiceX, "Player X");
        Peice peiceO = new PeiceO(PeiceType.O);
        Player playerO = new Player(peiceO, "Player O");

        players.AddFirst(playerX);
        players.AddLast(playerO);

    }
    
    public string StartGame(){
        bool noWinner = true;
        while(noWinner){
            
            Player playerTurn = players.First.Value;
            players.RemoveFirst();

            gameBoard.PrintBoard();
            List<(int, int)> freeSpaces = gameBoard.GetFreeCells();
            if (freeSpaces.Count == 0)
            {
                noWinner = false;
                continue;
            }

            Console.Write("Player: " + playerTurn.PlayerName + " Enter row,column: ");
            string input = Console.ReadLine();
            string[] values = input.Split(',');
            int inputRow = int.Parse(values[0]);
            int inputColumn = int.Parse(values[1]);

            // place the piece
            bool pieceAddedSuccessfully = gameBoard.AddPeice(inputRow, inputColumn, playerTurn.peice);
            if (!pieceAddedSuccessfully)
            {
                // player cannot insert the piece into this cell, player has to choose another cell
                Console.WriteLine("Incorrect position chosen, try again");
                players.AddFirst(playerTurn);
                continue;
            }
            players.AddLast(playerTurn);

            bool winner = gameBoard.CheckWinner(inputRow, inputColumn, playerTurn.peice.peiceType);
            if (winner)
            {
                gameBoard.PrintBoard();
                return playerTurn.PlayerName;
            }
        }

        return "tie";
    }
}