using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  class fsd
  {
    private async  Task<string> Wait1()
    {
      Console.WriteLine(" wait started- delay 1 sec");
      await Task.Delay(10);
      Console.WriteLine(" wait end - delay completed");

      for (int i = 0; i < 100; i++)
      {
        Console.WriteLine("wa");
      }

      return "anvi";
    }


    private async Task Wait()
    {
     await Task.Run(() =>
      {
        for (int i = 0; i < 100; i++)
        {
          Console.WriteLine(" anvi");
        }
      });

      //return "anvi";
    }


    private async Task str()
    {
      Console.WriteLine(" str - started wait 2 sec");

      //await Task.Delay(20);

      Console.WriteLine(" str - wait completed");

      for (int i = 0; i < 100; i++)
      {
        Console.WriteLine(" str " + i.ToString());
      }
      //return "sd";
    }


    private async Task<string> str1()
    {
      Console.WriteLine("sd");
      return "sd";
    }

    private void fss()
    {
      Console.WriteLine("fss");
      Thread.Sleep(10000);

      var f = "ewe";
    }


    public static async Task Method1()
    {
      await Task.Run(() =>
      {
        for (int i = 0; i < 100; i++)
        {
          Console.WriteLine(" Method 1");
        }
      });
    }


    public static void Method2()
    {
      for (int i = 0; i < 25; i++)
      {
        Console.WriteLine(" Method 2");
      }
    }


    public async Task<string> Taskme()
    {

      //Method1();
      //Method2();

      // await   Wait1();
      // await  str();

      var eggsTask = Wait1();
      var baconTask = str();

     await Task.WhenAll(eggsTask, baconTask);


      var f = "gfg"; 

      return "asd";
    }
  }
}
