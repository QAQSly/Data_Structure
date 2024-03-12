using System;
using System.IO;
namespace Recursion;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // CountDown(10);
        //int temp = Factorial(3);
        //Console.WriteLine(temp);
        PrintDir("./");
    }

    static void CountDown(int num)
    {
        if (num == 0)
        {
            return;
        }
        Console.WriteLine(num);
        CountDown(num - 1);
    }

    static int Factorial(int num)
    {
        if (num == 1)
        {
            return 1;
        }

        return num * Factorial(num -1);
    }


    static void PrintDir(string path)
    {
      string[] fileNames = Directory.GetDirectories(path,"*", SearchOption.TopDirectoryOnly);
      if (fileNames.Length < 1)
      {
          return;
      }

      foreach(var name in fileNames)
      {
          Console.WriteLine(name);
          PrintDir(name);
      }

    }
}
