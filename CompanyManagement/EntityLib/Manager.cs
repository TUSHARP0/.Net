using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account;
namespace EntityLib
{
    public class Manager:Employee,ISalaryable
    {
        private double HInsaurance;
        private double TAllowance;

        public double Insaurance { get { return HInsaurance; } set { this.HInsaurance = value; } }

        public double Allowance { get { return TAllowance; } set { this.TAllowance = value; } }

        public Manager(double HInsaurance,double TAllowance, int id, string name, double salary, DateTime joinDate, empType type) : base(id,name,salary,joinDate,type)
        {
            this.HInsaurance= HInsaurance;
            this.TAllowance= TAllowance;
        }

        public override string ToString()
        {
            return base.ToString()+" "+this.computeSalary();
        }

        public double computeSalary()
        {
            return base.computeSalary()+TAllowance+HInsaurance;
        }
    }
}
