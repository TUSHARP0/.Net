namespace EntityLib;
    using Account;
using System.ComponentModel.DataAnnotations;
[Serializable]

public class Employee:ISalaryable
    {
        private int id;
        private string name;
        private double salary;
        private DateTime joinDate;
        private empType type;

        public empType EmpType { get { return type; } set { type = value; } }

        public int Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }
        public double Sal { get { return salary; } set { salary = value; } }
        public DateTime Date { get { return joinDate; } set { joinDate = value; } }

        /*public Employee():this(1,"abc",852,new DateTime(2001,01,01),empType.TryParse("TEMPORARY"));*/
        
        public Employee()
    {

    }
    public Employee(int id,string name, double salary, DateTime joinDate, empType type)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.joinDate = joinDate;   
            this.type = type;   
        }
        
        public Employee(int id,string name,empType type)
    {
        this.id=id;
        this.name= name;
        this.type=type;
    }
        public override string ToString()
        {
            return this.id+" "+this.name+" "+this.computeSalary()+" "+this.joinDate+" "+this.type;
        }

    public double computeSalary()
    {
        double total = this.salary + 2000;
        return total;
    }
}
