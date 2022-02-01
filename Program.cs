//using System;

//namespace ConsoleApp3
//{
//  class Program
//  {
//    public static int Fib(int n)
//    {
//      if (n <= 1)
//      {
//        return n;
//      }
//      else
//      {
//        Console.Write(Fib(n - 1));
//        Console.Write(Fib(n - 2));
//        return Fib(n - 1) + Fib(n - 2);
//      }
//    }


//    static int findNthNumber(int A, int B, int N)
//    {

//      // To store the current element which 
//      // is the sum of previous two 
//      // elements of the series 
//      int sum = 0;

//      // This loop will terminate when 
//      // the Nth element is found 
//      for (int i = 2; i < N; i++)
//      {
//        sum = A + B;

//        A = B;

//        B = sum;
//      }

//      // Return the Nth element 
//      return sum;
//    }



//    public static void Main(string[] args)
//    {
//      fsd f = new fsd();
//      f.Taskme();


//      findNthNumber(1, 2, 3);





//      //string input = Console.ReadLine();
//      //Console.WriteLine(input);
//      //int n1 = 0, n2 = 1, n3, i, number;
//      //Console.Write("Enter the number of elements: ");
//      //// number = int.Parse(Console.ReadLine());
//      //number = 8;
//      //for (i = 2; i < number; ++i)
//      //{
//      //  n3 = n1 + n2;
//      //  n1 = n2;
//      //  n2 = n3;
//      //  if (i == (number - 1))
//      //  {
//      //    Console.Write(n3 + " ");
//      //  }
//      //}

//    }
//  }

//}
