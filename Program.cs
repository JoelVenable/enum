﻿using System;

namespace enum_tutorial
{
  class Program
  {
    static void Main(string[] args)
    {
      int solution;

      DoubleIt(15, out solution);

      System.Console.WriteLine(solution);

      int num1 = 10;
      int num2 = 20;

      System.Console.WriteLine("Before Swap num1: {0}, num2 {1}", num1, num2);
      Swap(ref num1, ref num2);
      System.Console.WriteLine("After Swap num1: {0}, num2 {1}", num1, num2);

      System.Console.WriteLine("1, 2, 3 = {0}", GetSumMore(1, 2, 3));

      PrintInfo(zipCode: 15137, name: "Joel");
    }

    static void DoubleIt(int x, out int solution)
    {

      solution = x * 2;

    }

    public static void Swap(ref int num1, ref int num2)
    {
      int temp = num1;
      num1 = num2;
      num2 = temp;
    }

    static double GetSumMore(params double[] nums)
    {
      double sum = 0;

      foreach (int i in nums)
      {
        sum += i;
      }
      return sum;
    }

    static void PrintInfo(string name, int zipCode)
    {
      System.Console.WriteLine($"{name} lives in {zipCode}");
    }
  }
}