namespace DAL
{
    using MySql.Data.MySqlClient;
    using BOL;
    using Org.BouncyCastle.Asn1;
    using System.Diagnostics;

    public class DBManager
    {
        public static string connString = @"server=localhost;port=3306;user=root;password=admin123;database=DotNetWebProject";
        public static List<Movie> GetMovies()
        {
            List<Movie> movieList = new List<Movie>();
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connString;
            try
            {
                conn.Open();
                MySqlCommand cmd= new MySqlCommand();
                cmd.Connection = conn;
                string query = "SELECT * FROM movies";
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["movieId"].ToString());
                    string movieName = reader["movieName"].ToString();
                    string actorName = reader["actorName"].ToString() ;
                    double ticketPrice = double.Parse(reader["ticketPrice"].ToString());
                    DateOnly releaseDate = DateOnly.FromDateTime(DateTime.Parse(reader["releaseDate"].ToString()));

                    Movie newMovie= new Movie(id,movieName,actorName,ticketPrice,releaseDate);
                    movieList.Add(newMovie);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return movieList;
        }

        public static void AddMovie(Movie m)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connString;
            try
            {
                con.Open();
                MySqlCommand cmd= new MySqlCommand();
                cmd.Connection = con;
                string query = "INSERT INTO movies VALUES('" + m.MOVIEID + "','"+m.MOVIENAME+"','"+m.ACTORNAME+"','"+m.PRICE+"','"+m.RELEASEDATE.ToString("yyyy-MM-dd")+"')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void delete(int movieId)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString=connString;
            try
            {
                con.Open();
                MySqlCommand cmd= new MySqlCommand();
                cmd.Connection = con;
                string query = "DELETE FROM movies WHERE movieId=" + movieId;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }catch(Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }
        }

        public static Movie getMovieById(int Id)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString=connString;
            Movie movie= new Movie();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection= conn;
                string query = "SELECT * FROM movies WHERE movieId=" + Id;
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = int.Parse(reader["movieId"].ToString());
                    string movieName = reader["movieName"].ToString();
                    string actorName = reader["actorName"].ToString();
                    double ticketPrice = double.Parse(reader["ticketPrice"].ToString());
                    DateOnly releaseDate = DateOnly.FromDateTime(DateTime.Parse(reader["releaseDate"].ToString()));

                    movie = new Movie(id, movieName, actorName, ticketPrice, releaseDate);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally { conn.Close(); }
            return movie;
        }
        public static void edit(Movie movie)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString=connString;
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                string query = "UPDATE movies SET movieName='" + movie.MOVIENAME + "',actorName='" + movie.ACTORNAME + "',ticketPrice='" + movie.PRICE + "',releaseDate='" + movie.RELEASEDATE.ToString("yyyy-MM-dd") + "' where movieId=" + movie.MOVIEID;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { con.Close(); }
        }
    }
}