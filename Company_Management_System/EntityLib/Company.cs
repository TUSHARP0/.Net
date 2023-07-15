using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EntityLib;
[Serializable]

    public class Company
    {
        private string companyName;
        private string licenceNo;
        private List<Employee> employeeList;

        public string CompanyName { get { return companyName; } set { companyName = value; } }
        public string Licence { get { return licenceNo; } set { licenceNo = value; } }
        public List<Employee> List { get { return employeeList; } set { employeeList = value; } }

        public Company(string companyName,string licenceNo) {
        this.companyName = companyName; 
            this.licenceNo = licenceNo; 
            employeeList = new List<Employee>();
        }

        public override string ToString()
        {
            return this.companyName+" "+this.licenceNo;
        }
    }

