namespace MNG;
using EMP;

public class Manager:Employee{
    private double TAllowance;
    private double HInsurance;

    public Manager(double TAllowance,double HInsurance,int empId,
    string empName,double salary,string email,string address)
    :base(empId,empName,salary,email,address){
        this.TAllowance=TAllowance;
        this.HInsurance=HInsurance;
    }

    public double Travelling{
        get{return this.TAllowance;}
        set{this.TAllowance=value;}
    }

    public double Health{
        get{return this.HInsurance;}
        set{this.HInsurance=value;}
    }

    public override double ComputeSal(){
        double total=base.ComputeSal()+TAllowance+HInsurance;
        return total;
    }

    public override string ToString(){
        return base.ToString()+" "+this.TAllowance+" "+this.HInsurance;
    }
}