namespace EMP;

public class Employee{
    private int empId;
    private string empName;
    private double salary;
    private string email;
    private string address;

    public Employee(int empId,string empName,double salary,string email,string address){
        this.empId=empId;
        this.empName=empName;
        this.salary=salary;
        this.email=email;
        this.address=address;
    }

    public int ID{
        get{return this.empId;}
        set{this.empId=value;}
    }
        public string Name{
        get{return this.empName;}
        set{this.empName=value;}
    }
        public double sal{
        get{return this.salary;}
        set{this.salary=value;}
    }
        public string Email{
        get{return this.email;}
        set{this.email=value;}
    }
        public string Add{
        get{return this.address;}
        set{this.address=value;}
    }

    public virtual double ComputeSal(){
        return this.salary;
    } 

    public override string ToString(){
        return this.empId+" "+this.empName+" "+this.salary+" "+this.email+" "+this.address;
    }
}
