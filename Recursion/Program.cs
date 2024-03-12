using System;
using System.IO;
namespace Recursion;

class Program
{
    public static int[] arr = {0, 5, 2, 1, 6, 3};
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // CountDown(10);
        //int temp = Factorial(3);
        //Console.WriteLine(temp);
        // PrintDir("./");
        Partition(0, 5);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
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
    static void Swap(int a, int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

    static void Partition(int leftIndex, int rightIndex)
    {
        int shaftIndex = rightIndex;
        int shaftValue = arr[shaftIndex];
        rightIndex -= 1;

        while (true)
        {
            while (arr[leftIndex] < shaftValue)
            {
                ++leftIndex;
            }

            while (arr[rightIndex] > shaftValue)
            {
                --rightIndex;
            }


            if (leftIndex >= rightIndex)
            {
                break;
            }
            Swap(leftIndex, rightIndex);
        }
        Swap(leftIndex, shaftIndex);
    }
}
