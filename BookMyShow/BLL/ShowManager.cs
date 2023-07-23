namespace BLL
{
    using BOL;
    using DAL;
    public class ShowManager
    {
        public static List<Movie> getMovies()
        {
            List<Movie> list = new List<Movie>();
            list=DBManager.GetMovies();
            return list;
        }

        public static void Insert(Movie movie)
        {
            DBManager.AddMovie(movie);
        }

        public static void Delete(int movieId)
        {
            DBManager.delete(movieId);
        }

        public static void Edit(Movie movie)
        {
            DBManager.edit(movie);
        }

        public static Movie getById(int movieId)
        {
            Movie m= DBManager.getMovieById(movieId);
            return m;
        }
    }
}