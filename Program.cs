using System;

namespace enum_tutorial
{
  class Program
  {
    static void Main(string[] args)
    {
      int solution;

      DoubleIt(15, out solution);

      System.Console.WriteLine(solution);
    }

    static void DoubleIt(int x, out int solution)
    {

      solution = x * 2;

    }
  }
}