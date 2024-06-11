namespace TicTacToe;

public class Player
{

    public Peice peice {get;}
    public string PlayerName {get;}
    public Player(Peice peice, string name){
            this.peice = peice;
            this.PlayerName = name;
    }
    
}