namespace BOL
{
    public enum Department
    {
        HR,SALES,FINANCE, MARKETING, SUPPORT
    }
    public class Employee
    {
        private int id;
        private string empname;
        private string designation;
        private Department department;
        private string city;
        private double salary;
        private DateOnly joinDate;

        public Employee(int id, string empname,string designation,Department department,string city,double salary,DateOnly joinDate)
        {
            this.id = id;
            this.empname = empname;
            this.designation = designation;
            this.department = department;
            this.city = city;
            this.salary = salary;
            this.joinDate = joinDate;
        }

        public Employee()
        {

        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return empname; }
            set { empname = value; }
        }

        public string DESIGNATION
        {
            get { return designation; }
            set { designation = value; }
        }

        public Department DEPARTMENT
        {
            get { return department; }
            set { department = value; }
        }

        public string CITY
        {
            get { return city; }
            set {city = value; }
        }

        public double SALARY
        {
            get { return salary; }
            set { salary = value; }
        }

        public DateOnly JOINDATE
        {
            get { return joinDate; }
            set { joinDate = value; }
        }
        public override string ToString()
        {
            return this.id+" "+this.empname+" "+this.designation+" "+this.department+" "+this.city+" "+this.salary+" "+this.joinDate; 
        }
    }
}