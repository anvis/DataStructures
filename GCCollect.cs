using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    using System;
class MyGCCollectClass
  {
    private const int maxGarbage = 1000;
    //static void Main()
    //{

    //  Console.WriteLine("Memory initialize: {0:N0}",
    // GC.GetTotalMemory(false));

    //  // Put some objects in memory.
    //  MyGCCollectClass.MakeSomeGarbage();
    //  Console.WriteLine("Memory used before collection: {0:N0}",
    //  GC.GetTotalMemory(false));
    //  // Collect all generations of memory.
    //  GC.Collect();
    //  Console.WriteLine("Memory used after full collection: {0:N0}",
    //  GC.GetTotalMemory(true));
    //}
    static void MakeSomeGarbage()
    {
      Version vt;
      // Create objects and release them to fill up memory with unused objects.
      for (int i = 0; i < maxGarbage; i++)
      {
        vt = new Version();
      }
    }
  }


}
