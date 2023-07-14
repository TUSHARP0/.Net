using EntityLib;
using Account;
using System.Xml.Linq;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Mars");
Employee e1= new Employee(1,"Tushar",88888,new DateTime(2020,01,01),Enum.Parse<empType>("PERMANENT"));
Employee e2 = new Employee(2, "Somesh", 77777, new DateTime(2021, 01, 01), Enum.Parse<empType>("PERMANENT"));
Employee e3 = new Employee(3, "Saurabh", 66666, new DateTime(2022, 01, 01), Enum.Parse<empType>("TEMPORARY"));

Manager m1 = new Manager(5000, 1000, 4, "Shruti", 98740, new DateTime(2023, 05, 02), Enum.Parse<empType>("PERMANENT"));

Company company=new Company("Mars Pvt Ltd","HGHS852");
company.List.Add(e1);
company.List.Add(e2);
company.List.Add(e3);
company.List.Add(m1);

bool exit = false;
while (!exit)
{
    Console.WriteLine("1. Add Employee");
    Console.WriteLine("2. Display List of All Employee");
    Console.WriteLine("2. Display List of Employee only");
    Console.WriteLine("2. Display List of Manager only");
    Console.WriteLine("0. Exit");

    Console.WriteLine("Enter Choice");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine("Id, Name, Salary, Join Date, Type(TEMPORARY/PERMANENT)");

            Employee emp= new Employee(Convert.ToInt32(Console.ReadLine()),Console.ReadLine(),Convert.ToDouble(Console.ReadLine()),DateTime.Parse(Console.ReadLine()),
                Enum.Parse<empType>(Console.ReadLine()));
            company.List.Add(emp);
            break;

        case "2":
            List<Employee> emplist= company.List;
            Console.WriteLine("Employee Details");
            foreach(Employee e in emplist)
            {
                Console.WriteLine(e);
            }
            break;

        case "3":
            List<Employee> eList=company.List;
           foreach(var e in eList)
            {
                if(e.GetType() == typeof(Employee))
                {
                    Console.WriteLine(e);
                }
                if(e.GetType() == typeof(Manager))
                {
                    Console.WriteLine(e);
                }
            }
           
            break;

        case "4":
            List<Employee> mList = company.List;
            foreach (var e in mList)
            {
                if (e.GetType() == typeof(Manager))
                {
                    Console.WriteLine(e);
                }
            }
            break;

        case "0":
            exit = true;
            break;
    }
}

