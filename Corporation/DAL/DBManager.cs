namespace DAL
{
    using BOL;
    using MySql.Data.MySqlClient;
    public class DBManager
    {
        public static string connString = @"server=localhost;port=3306;user=root; password=admin123;database=DotNetWebProject"; 
       
        public static List<Employee> GetEmployees()
        {
             List<Employee> emplist = new List<Employee>();
        MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connString;

            try {
                conn.Open();
                MySqlCommand cmd= new MySqlCommand();
                cmd.Connection = conn;
                string query = "SELECT * FROM employees";
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id=int.Parse(reader["id"].ToString());
                    string empname = reader["empname"].ToString();
                    string designation = reader["designation"].ToString() ;
                    Department department = Enum.Parse<Department>(reader["department"].ToString());
                    string city = reader["city"].ToString();
                    double salary = double.Parse(reader["salary"].ToString());
                    DateOnly joinDate = DateOnly.FromDateTime(DateTime.Parse(reader["joinDate"].ToString())) ;

                    Employee emp = new Employee(id,empname,designation,department,city,salary,joinDate);
                    emplist.Add(emp);

                }
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return emplist;
        }

        public static void insertEmployee(Employee emp)
        {
            MySqlConnection conn=new MySqlConnection();
            conn.ConnectionString = connString;

            try
            {
                conn.Open();
                MySqlCommand cmd= new MySqlCommand();
                cmd.Connection = conn;
                string query = "INSERT INTO employees VALUES('"+emp.ID+"','"+emp.Name+ "','"+emp.DESIGNATION+ "','"+emp.DEPARTMENT+"','"+emp.CITY+"','"+emp.SALARY+"')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            finally { conn.Close(); }
        }

        public static void deleteEmployee(int id)
        {
            MySqlConnection conn=new MySqlConnection();
            conn.ConnectionString=connString;
            try
            {
                conn.Open();
                MySqlCommand cmd= new MySqlCommand();
                cmd.Connection = conn;
                string query = "DELETE FROM employees where id="+id;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static Employee getById(int id)
        {
            Employee emp= new Employee();
            MySqlConnection conn=new MySqlConnection();
            conn.ConnectionString=connString;
            try
            {
                conn.Open();
                MySqlCommand cmd= new MySqlCommand();
                cmd.Connection = conn;
                string query = "SELECT * FROM employees WHERE id=" + id;
                cmd.CommandText = query;
                MySqlDataReader reader=cmd.ExecuteReader();
                if (reader.Read())
                {
                    int eid= int.Parse(reader["id"].ToString());
                    string empname = reader["empname"].ToString();
                    string designation = reader["designation"].ToString() ;
                    Department department = Enum.Parse<Department>(reader["department"].ToString());
                    string city = reader["city"].ToString();
                    double salary = double.Parse(reader["salary"].ToString());
                    DateOnly joinDate = DateOnly.FromDateTime(DateTime.Parse(reader["joinDate"].ToString()));

                    emp =new Employee(eid,empname,designation,department,city,salary,joinDate);
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return emp;
        }

        public static void updateEmployee(Employee emp)
        {
            MySqlConnection con=new MySqlConnection();
            con.ConnectionString=connString;
            try
            {
                con.Open();
                MySqlCommand cmd= new MySqlCommand();
                cmd.Connection = con;
                string query="UPDATE employees SET empname='"+emp.Name+"',designation= '"+emp.DESIGNATION+"'," +
                    "department='"+emp.DEPARTMENT+"',city='"+emp.CITY+"',salary='"+emp.SALARY+"' where id="+emp.ID;
                cmd.CommandText=query;
                cmd.ExecuteNonQuery();
            }catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
            finally { con.Close(); }

        }
    }
}