namespace BookMyShow;
public class Show
{
    public int showId {get; set;}
    public Movie movie {get; set;}
    public Screen screen {get; set;}
    public DateTime startTime {get; set;}
    public List<Seat> bookedSeats {get; set;}
    
}
