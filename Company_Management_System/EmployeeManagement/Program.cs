using EntityLib;
using Account;
using System.Xml.Linq;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;

Console.WriteLine("Welcome to Mars");
Company company = new Company("Mars Pvt Ltd", "HGHS852");
bool exit = false;
List<Employee> main = new List<Employee>();
string empList = File.ReadAllText(@"D:\empList.json");
List<Employee> empListJson = JsonSerializer.Deserialize<List<Employee>>(empList);
Console.WriteLine("ALL Employee Details");
/*foreach (Employee e in empListJson)
{   
    Console.WriteLine(e);
    *//*.Console WriteLine($"{e.Id}:{e.Name}:{e.EmpType}");*//*
}*/
Console.WriteLine();
Console.WriteLine("File Deserialization Successfull");

Console.WriteLine(" ");

main = empListJson;
while (!exit)
{
    Console.WriteLine("1. Add Employee");
    Console.WriteLine("2. Display List of All Employee");
    Console.WriteLine("3. Display List of Employee only");
    Console.WriteLine("4. Display List of Manager only");
    Console.WriteLine("5. Serialization");
    Console.WriteLine("6. Add Manager");
    Console.WriteLine("7. Add Populated Data of Employees");
    Console.WriteLine("8. Add Populated Data of Managers");
    Console.WriteLine("0. Exit");
    Console.WriteLine();
    Console.WriteLine("Enter Choice");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine("Id, Name, Salary, Join Date, Type(TEMPORARY/PERMANENT)");

            Employee emp= new Employee(Convert.ToInt32(Console.ReadLine()),Console.ReadLine(),Convert.ToDouble(Console.ReadLine()),DateTime.Parse(Console.ReadLine()),
                Enum.Parse<empType>(Console.ReadLine()));
            main.Add(emp);
            Console.WriteLine();
            break;

        case "2":
            List<Employee> emplist= main;
            Console.WriteLine("Employee Details");
            foreach(Employee e in emplist)
            {
                Console.WriteLine();
                Console.WriteLine(e);
                Console.WriteLine();
            }
            break;

        case "3":
            List<Employee> eList=main;
           foreach(var e in eList)
            {
                if(e.GetType() == typeof(Employee))
                {
                    Console.WriteLine(e);
                }
            }
           
            break;

        case "4":
            foreach (var e in main)
            {
                if (e.GetType() == typeof(Manager))
                {
                    Console.WriteLine(e);
                }
            }
            break;

        case "5":
            try
            {
                /*List<Employee> list = company.List;*/
                var options = new JsonSerializerOptions { IncludeFields = true };
                var empJson = JsonSerializer.Serialize<List<Employee>>(main, options);
                string filename = @"D:\empList.json";
                File.WriteAllText(filename, empJson);
                Console.WriteLine("File Stored");
                Console.WriteLine();
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            break;

        case "6":
            Console.WriteLine("TA,HI,id,name,sal,joinDate,type");
            Manager m1 = new Manager(Convert.ToDouble(Console.ReadLine()), 
                Convert.ToDouble(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), 
                Console.ReadLine(), Convert.ToDouble(Console.ReadLine()), 
                DateTime.Parse(Console.ReadLine()), Enum.Parse<empType>(Console.ReadLine()));
            main.Add(m1);
            Console.WriteLine();

            Console.WriteLine("Manager Added");
    
            break;

        case "7":
            Employee e1 = new Employee(1, "Tushar", 88888, new DateTime(2020, 01, 01), Enum.Parse<empType>("PERMANENT"));
            Employee e2 = new Employee(2, "Somesh", 77777, new DateTime(2021, 01, 01), Enum.Parse<empType>("PERMANENT"));
            Employee e3 = new Employee(3, "Saurabh", 66666, new DateTime(2022, 01, 01), Enum.Parse<empType>("TEMPORARY"));
                        
            main.Add(e1);
            main.Add(e2);
            main.Add(e3);
            Console.WriteLine("Employees added successfully");
            break;

        case "8":
            Manager m2 = new Manager(5000, 1000, 7, "Ashwini", 98778, new DateTime(2023, 05, 02), Enum.Parse<empType>("PERMANENT"));
            Manager m3 = new Manager(1000, 500, 8, "Pratiksha", 98788, new DateTime(2023, 07, 07), Enum.Parse<empType>("PERMANENT"));
            Manager m4 = new Manager(2000, 600, 9, "Manasi", 98799, new DateTime(2023, 08, 08), Enum.Parse<empType>("TEMPORARY"));

            main.Add(m2);
            main.Add(m3);
            main.Add(m4);

            Console.WriteLine("Manager Added Successfully");
            Console.WriteLine();
            break;
        case "0":
            exit = true;
            break;
    }
}

