namespace TicTacToe;

public class Board
{
    public int size {get; set;}

    public Peice[,] board {get; set;}

    public Board(int size){
        this.size = size;
        board = new Peice[size, size];
    }
    
    public bool AddPeice(int row, int col, Peice peice){
        if(board[row, col] != null){
            return false;
        }
        board[row, col] = peice;
        return true;
    }

    public List<(int, int)> GetFreeCells(){
        var freeCells = new List<(int, int)>();
        for(int i=0;i<size;i++){
            for(int j=0;j<size;j++){
                if(board[i, j]==null){
                    freeCells.Add((i,j));
                }
            }
        }
        return freeCells;
    }

    public bool CheckWinner(int row, int col, PeiceType peiceType){
        bool rowWin = true;
        bool colWin = true;
        bool diagonalWin = true;
        bool antiDiagonalWin = true;

        for (int i=0;i<size;i++){
            if(board[row, i] == null || board[row, i].peiceType != peiceType){
                rowWin = false;
            } 
        }

        for (int i=0;i<size;i++){
            if(board[i, col] == null || board[i, col].peiceType != peiceType){
                colWin = false;
            } 
        }

        for (int i=0, j=0;i<size;i++, j++){
            if(board[i, j] == null || board[i, j].peiceType != peiceType){
                diagonalWin = false;
            }
        }

        for (int i=0, j=size-1;i<size;i++, j--){
            if(board[i, j] == null || board[i, j].peiceType != peiceType){
                antiDiagonalWin = false;
            } 
        }

        return rowWin || diagonalWin || antiDiagonalWin || colWin;
    
    }

    public void PrintBoard(){
        for(int i=0;i<size;i++){
            for(int j=0;j<size;j++){
                if (board[i,j]!=null){
                    Console.Write(board[i, j].peiceType + "  ");
                }
                else{
                    Console.Write("   ");
                }
                if(j<size-1){
                    Console.Write("|");
                }
            }
            Console.WriteLine("");
        }
    }
    
}