namespace STUD;
using IACSD;
using CDAC;
public class Student: IPlaceable, IInstitutable{
    public int rollNo;
    public string name;
    public int cceScore;
    public string course;
    public bool isDecipline;
    public int attendance;
    public string projectName;
    public bool isProjectCompleted;

    public Student(int rollNo,string name,int cceScore,string course,bool isDecipline,
    int attendance,string projectName,bool isProjectCompleted){
        this.rollNo=rollNo;
        this.name=name;
        this.cceScore=cceScore;
        this.course=course;
        this.isDecipline=isDecipline;
        this.attendance=attendance;
        this.projectName=projectName;
        this.isProjectCompleted=isProjectCompleted;
    }

    string IInstitutable.Attendance(){
        
        if(this.attendance > 75){
            return "(Name: "+this.name+", Roll No: "+this.rollNo+") Student attendance is more than 75%";            
        }else{
             return "(Name: "+this.name+", Roll No: "+this.rollNo+") Student attendance is less than 75%";
        }
    }

     string IInstitutable.Discipline(){
        if(isDecipline){
            return "(Name: "+this.name+", Roll No: "+this.rollNo+") Student has followed all rules as per institue";
        }
        else{
           return "(Name: "+this.name+", Roll No: "+this.rollNo+") Student has a Non-Professional Behaviour";
        }
    } 

     string IPlaceable.CCEScore(){
        if(this.cceScore > 60){
           return "(Name: "+this.name+", Roll No: "+this.rollNo+") Student is Eligible for interview";
        }else{
            // Console.WriteLine(this.name+" ("+this.rollNo+") Student Is Not Eligible Because Of Less CCE Score");
            // return false;
            return "(Name: "+this.name+", Roll No: "+this.rollNo+") Student is not eligible for interview because of getting "+this.cceScore+" marks";
        }
    }

     string IPlaceable.projectClearance(){
        if(isProjectCompleted){
            return "(Name: "+this.name+", Roll No: "+this.rollNo+") Student Project is Completed";
        }else{
            // Console.WriteLine(this.name+" ("+this.rollNo+") Student Is Not Eligible Because Project Is Not Completed");
            // return false;
            return "(Name: "+this.name+", Roll No: "+this.rollNo+") Student Project is Incomplete";
        }
    }

    public override string ToString(){
        return "RollNo: "+this.rollNo+" Student name: "+this.name+" CCE Score: "+this.cceScore+" Course: "+this.course+"Is Student Disciplined(true/false): "+this.isDecipline+
        " Attendance: "+this.attendance+" Project Name: "+this.projectName+" Is Project Completed(true/false): "+this.isProjectCompleted;
    }

}