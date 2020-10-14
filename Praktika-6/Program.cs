using System;
using System.Collections.Generic;
namespace Praktika_6
{
  class Person
  {
    private string name;
    private string fam;
    private System.DateTime date;
    public Person(string f, string n, DateTime d)
    {
      fam = f;
      name = n;
      date = d;
    }
    public Person()
    {
      fam = "nobody";
      name = "nobody";
      date = new DateTime(2001, 1, 1);
    }
    public string Name
    {
      get {return name;}
      set {name = value;}
    }
    public string Fam
    {
      get { return fam; }
      set { fam = value; }
    }
    public DateTime Date
    {
      get { return date;}
      set {date = value;}
    }
    public int Year//как изменить дэйттайм год??
    {
      get { return date.Year; }
      set {  }
    }
    public override string ToString()
    {
      return fam + " " + name + " was born on " + date.ToShortDateString();
    }
    public virtual string ToShortString()
    {
      return fam + " " + name;
    }
  }
  class Exam
  {

    public string NameOfSub { get; set; }
    public int Mark { get; set; }
    public DateTime DateOfExam {get; set;}

    public Exam(string name, int oc, DateTime time)
    {
      NameOfSub = name;
      Mark = oc;
      DateOfExam = time;
    }
    public Exam()
    {
      NameOfSub = " ";
      Mark = 0;
      DateOfExam = new DateTime(2000,1,1);
    }
    public override string ToString()
    {
      return NameOfSub + ": " + Mark + " date: " + DateOfExam.ToShortDateString();
    }
  }
  enum Education: int { Specialist, Вachelor, SecondEducation };
  class Student
  {
    private Person DataOfStudent;
    private Education Form;
    private int Group;
    //private Exam[] Exams;
    private List<Exam> Exams=new List<Exam>();
    public Student(Person p, Education e, int g)
    {
      DataOfStudent = p;
      Form = e;
      Group = g;
    }
    public Student()
    {
      DataOfStudent = new Person();
      Form = 0;
      Group = 0;
    }
    public Person data
    {
      get { return DataOfStudent; }
      set { DataOfStudent = value; }
    }
    public Education form
    {
      get { return Form; }
      set { Form = value; }
    }
    public int group
    {
      get { return Group; }
      set { Group = value; }
    }
    public List<Exam> exams
    {
      get { return Exams; }
      set {
        if (Exams.Count != 0)
                {
                    Exams.Clear();
                }
        foreach(Exam _exam in value)
                {
                    Exams.Add(_exam);
                }
      }
    } 
    
    public double MidMark
    {
      get 
      {
        double midmark=0.0;
        int i = 0;
        foreach(Exam _mark in Exams)
        {
          midmark += _mark.Mark;
          i++;
        }
        return midmark/i;
      }
    }
    //индексатор булевского типа????
    public bool this[Education forma]
        {
            get
            {
                return forma==form;
            }
        }

    public void AddExams(List<Exam> list)
    {
      foreach(Exam _element in list)
      {
        exams.Add(_element);
      }
    }
    public override string ToString()
    {
      string str="";
      int i = 0;
      foreach (Exam _exam in Exams)
      { 
        i++;
        str =str + i + ". "  + _exam.ToString() + "\n";
      }
      return DataOfStudent.ToString() + "\nform of education: " + Form + "\ngroup: " + Group + "\n" + str;
    }
    public virtual string ToShortString()
    {
      return DataOfStudent.ToString() + "\nform of education: " + Form + "\ngroup: " + Group + "\n" + "middle mark: " + MidMark;
    }
  }

  class Program
  {
    
    static void Main(string[] args)
    {
            Student stud=new Student();
            Console.WriteLine(stud.ToShortString());
            Console.WriteLine(stud[Education.Specialist]);
            Console.WriteLine(stud[Education.Вachelor]);
            Console.WriteLine(stud[Education.SecondEducation]);
            var date = new DateTime(2000,11, 7);
            stud.data=new Person("black","Tom",date);
            stud.form = Education.Вachelor;
            stud.group = 5;
            var date1 = new DateTime(2020, 6, 4);
            var date2 = new DateTime(2020, 6, 17);
            List<Exam> exams1 = new List<Exam>();
            exams1.Add(new Exam("algebra", 5, date1));
            exams1.Add(new Exam("geometry", 4, date2));
            stud.exams=exams1;
            Console.WriteLine(stud.ToString());
            List<Exam> exams2 = new List<Exam>();
            var date3 = new DateTime(2020, 6, 23);
            exams2.Add(new Exam("history", 3, date3));
            stud.AddExams(exams2);
            Console.WriteLine(stud.ToString());
           
        }
  }
}
