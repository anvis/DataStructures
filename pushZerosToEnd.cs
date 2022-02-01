using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
  //class swaparray
  //{
  //  static void Main(string[] args)
  //  {
  //    int[] a = { 29, 15, 0, 98, 0, 0, 99, 0 };
            

  //    for (int i = 0; i < a.Length - 1; i++)
  //    {

  //      if (a[i] == 0)
  //      {
  //       // int k = i;         

  //        if (a[i+1] > 0)
  //        {
  //          int tmp = a[i + 1];
  //          a[i + 1] = 0;
  //          a[i] = tmp;
  //        }else
  //        {
  //          int j = i;

  //          while (j < a.Length - 1 && a[j + 1] == 0)
  //          {
  //            j++;
  //          }
  //          if (j != a.Length - 1)
  //          {
  //            a[i] = a[j + 1];
  //            a[j] = 0;
  //          }
  //         // a[i] = tmp;

  //        }
  //      }

  //      //int tmp = a[i];
  //      //a[i] = a[a.Length - i - 1];
  //      //a[a.Length - i - 1] = tmp;
  //    }

  //    foreach (var item in a)
  //    {
  //      Console.WriteLine(item);
  //    }

  //  }
  //}




  /* C# program to push zeroes to back of array */
using System; 

class PushZero
  {
    // Function which pushes all zeros 
    // to end of an array. 
    static void pushZerosToEnd(int[] arr, int n)
    {
      // Count of non-zero elements 
      int count = 0;

      // Traverse the array. If element encountered is 
      // non-zero, then replace the element 
      // at index â..countâ.. with this element 
      for (int i = 0; i < n; i++)
        if (arr[i] != 0)

          // here count is incremented 
          arr[count++] = arr[i];

      // Now all non-zero elements have been shifted to 
      // front and â..countâ.. is set as index of first 0. 
      // Make all elements 0 from count to end. 
      while (count < n)
        arr[count++] = 0;
    }

    // Driver function 
    //public static void Main()
    //{
    //  int[] arr = { 0, 0, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9 };
    //  int n = arr.Length;
    //  pushZerosToEnd(arr, n);
    //  Console.WriteLine("Array after pushing all zeros to the back: ");
    //  for (int i = 0; i < n; i++)
    //    Console.Write(arr[i] + " ");
    //}
  }
  /* This code is contributed by Anant Agrawal */

}
