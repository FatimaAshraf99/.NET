using System;
using System.Data.Common;
using System.Collections.Generic;
class Student
{
            public string studentId{get;set;}="";
            public string name{get;set;}="";
            public string email{get;set;}="";
            public string age{get;set;}="";
            public string course{get;set;}="";
}
class Program{
                static List<Student> students=new List<Student>();

   static void Main(string[] args)
    {
                int choice=int.Parse(Console.ReadLine() ?? "0");
        switch (choice)
        {
            case 1:
            AddStudent();
            break;
            case 2:
            Display();
            break;
            case 3:
            search();
            break;
            default:
            Console.WriteLine("Invalid Input");
            break;


        }


   
      
    }

            static void AddStudent()
    {
        Student student1=new Student();
        student1.studentId=Console.ReadLine() ?? "";
        student1.name=Console.ReadLine() ?? "";
        student1.email=Console.ReadLine() ?? "";
        student1.age=Console.ReadLine() ?? "";
        student1.course=Console.ReadLine() ?? "";

        students.Add(student1);

    }
    static void Display()
    {
        foreach(Student student in students)
    {
        Console.WriteLine(student.studentId);
        Console.WriteLine(student.name);
                Console.WriteLine(student.email);
                        Console.WriteLine(student.course);
                                Console.WriteLine(student.age);





        
    }
        
    }
    static void search()
    {
        string Id=Console.ReadLine() ?? "";
        string Name=Console.ReadLine()?? "";
        string Email=Console.ReadLine()?? "";
        string Age=Console.ReadLine() ?? "";
        string Course=Console.ReadLine() ?? "";

                foreach(Student student in students)
        {
            if (student.studentId == Id){
                Console.WriteLine(student.name);
            }
        }


    }
}

 