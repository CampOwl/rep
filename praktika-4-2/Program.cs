using System;
using System.Collections;

namespace prak4_02_upr01
{
  class Program
  {
    static void Main(string[] args)
    {
      Queue queue = new Queue();//очередь

      queue.Enqueue("1");
      queue.Enqueue("2");
      queue.Enqueue("3");
      queue.Enqueue("4");

      while (queue.Count > 0)
      {
        object obj = queue.Dequeue();
        Console.WriteLine("From Queue: {0}", obj);
      }
      Stack stack = new Stack();//стэк
      stack.Push("1");
      stack.Push("2");
      stack.Push("3");
      stack.Push("4");
      while (stack.Count > 0)
      {
        object obj = stack.Pop();
        Console.WriteLine("'From Stack: {0}", obj);
      }

    }
  }
}
