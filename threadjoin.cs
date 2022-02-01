using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp3
{
  // http://www.albahari.com/threading/#_Thread_Pooling

  class threadjoin
  {


    public static void test1()
    {
      Thread.Sleep(4000);
      Console.Write("y");
    }

    public static void Test2()
    {
      Thread.Sleep(3500);
      Console.Write("x");
    }

  //  public static void Main()
		//{
  //    Thread t = new Thread(test1);
      

  //    // test1();
  //    Thread t2 = new Thread(Test2);


  //    t.Priority = ThreadPriority.Highest;
  //    t2.Priority = ThreadPriority.BelowNormal;


  //    t.Start();
  //    t2.Start();
  //    t2.Join();   // acts as await. 
  //    //
  //    Console.WriteLine("Thread t has terminated !");

  //  }
  }
}
