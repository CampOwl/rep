using System;
using System.Collections;

namespace prakt4_01
{
  class Program
  {

    static void Main(string[] args)
    {
      ArrayList myList = new ArrayList();//список
      myList.Add("ABC");
      myList.Add("cbd");
      myList.Add("abc");
      myList.Add("xyz");
      foreach (string item in myList)
      {
        Console.WriteLine("Unsorted: {0}", item);
      }
      // Сортировка при помощи стандартного объекта сравнения 
      myList.Sort();
      foreach (string item in myList)
      {
        Console.WriteLine("   Sorted: {0}", item);
      }

    }

  }
}
