using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
  using System;
  public struct Complex
  {
    public int real;
    public int imaginary;

    static int test;

    public Complex(int real, int imaginary)
    {
      this.real = real;
      this.imaginary = imaginary;

      test = real + imaginary;
    }
    public static Complex operator +(Complex one, Complex two)
    {
      return new Complex(one.real + two.real, one.imaginary + two.imaginary);
    }
    public override string ToString()
    {
      return (String.Format("{0} + {1}i", real, imaginary));
    }

    public void checktest()
    {
      Console.WriteLine(test);
    }

     }
  class Demo
  {
    //static void Main()
    //{
    //  Complex val1 = new Complex(7, 1);                Console.WriteLine("tetsing Test");  val1.checktest();
    //  Complex val2 = new Complex(2, 6);
    //  // Add both of them
    //  Complex res = val1 + val2;
    //  Console.WriteLine("First: {0}", val1);
    //  Console.WriteLine("Second: {0}", val2);

    //  Console.WriteLine("tetsing Test");
    //  val2.checktest();

    //  // display the result
    //  Console.WriteLine("Result (Sum): {0}", res);
    //  Console.ReadLine();
    //}
  }
}
