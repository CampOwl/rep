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
      date = new DateTime(0, 0, 0);
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
      return fam + " " + name + " was born on " + date.ToString();
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
      DateOfExam = new DateTime(0,0,0);
    }
    public override string ToString()
    {
      return NameOfSub + ": " + Mark + " date: " + DateOfExam.ToString();
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
        int i = 0;
        foreach (Exam _exam in value)
        {
          exams[i++] = _exam;
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
    public void AddExams(params Exam[] list)
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
      return DataOfStudent.ToString() + "\n" + Form + "\n" + Group + "\n" + str;
    }
    public virtual string ToShortString()
    {
      return DataOfStudent.ToString() + "\n" + Form + "\n" + Group + "\n" + "middle mark: " + MidMark;
    }
  }

  class Program
  {
    
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
