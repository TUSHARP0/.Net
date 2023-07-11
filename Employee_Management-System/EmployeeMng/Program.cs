using MNG;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Manager mng= new Manager(500,5000,1,
    "Tushar",20000,"tushar@gmail.com","Nashik");
Console.WriteLine(mng);

Console.WriteLine("Manager Computed Salary: ");
Console.WriteLine(mng.ComputeSal());
