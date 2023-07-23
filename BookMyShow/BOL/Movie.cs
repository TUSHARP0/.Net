namespace BOL
{
    public class Movie
    {
        private  int movieId;

        private string movieName;

        private string actorName;

        private double ticketPrice;

        private DateOnly releaseDate;


        public Movie()
        {

        }

        public Movie(int movieId,string movieName,string actorName,double ticketPrice,DateOnly releaseDate)
        {
            this.movieId = movieId;
            this.movieName = movieName;
            this.actorName = actorName;
            this.ticketPrice = ticketPrice;
            this.releaseDate = releaseDate;
        }

        public int MOVIEID
        {
            get { return movieId; }
            set { this.movieId = value; }
        }

        public string MOVIENAME
        {
            get { return movieName; }
            set { this.movieName = value; }
        }

        public string ACTORNAME
        {
            get { return actorName; }
            set { this.actorName = value; }
        }

        public double PRICE
        {
            get { return ticketPrice; }
            set { this.ticketPrice = value; }
        }

        public DateOnly RELEASEDATE
        {
            get { return releaseDate; }
            set { this.releaseDate = value; }
        }


        public override string ToString()
        {
            return this.movieId+" "+this.movieName+" "+this.actorName+" "+this.ticketPrice+" "+this.releaseDate;
        }
    }
}