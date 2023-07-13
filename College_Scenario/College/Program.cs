using STUD;
using IACSD;
using CDAC;

Console.WriteLine("Hello, World!");

//Positive Case for Student
Student stud1=new Student(1,"Tushar",95,"DAC",true,
    85,"IT Galaxy",true);

IPlaceable p1=stud1;
IInstitutable i1=stud1;
    Console.WriteLine(i1.Attendance());
    Console.WriteLine(i1.Discipline());
    Console.WriteLine(p1.projectClearance());
    Console.WriteLine(p1.CCEScore());
    Console.WriteLine();
//Negative Case For Student

Student stud2=new Student(2,"Mohit",50,"DAC",false,50,"Shopping Cart",false);
IPlaceable p2=stud2;
IInstitutable i2=stud2;
    Console.WriteLine(i2.Attendance());
    Console.WriteLine(i2.Discipline());
    Console.WriteLine(p2.projectClearance());
    Console.WriteLine(p2.CCEScore());
