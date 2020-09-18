using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] text ={"Макс",
        "C++",
        " +79263772622",
        " 89263772622",
        " (926)3772622",
      " +7-945-677-44-55",
      "8(098)456-56-56"};

      foreach (string item in text)
      {
        string pattern = @"[+7,8]{0,1}[(,-]{0,1}\d{3}[)-]{0,1}\d{3}\-?\d{2}\-?\d{2}$";
        if (Regex.IsMatch(item, pattern))
        {
          //Console.WriteLine($"{item} это телефон"); 
          Console.WriteLine(item + " это телефон");
        }
        else
        {
          Console.WriteLine(
          string.Format("{0} это НЕ телефон", item)
          );
        }

      }

    }
  }
}
