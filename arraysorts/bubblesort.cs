using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.arraysorts
{
  
	
  // C# program for implementation 
// of Bubble Sort 
class bubblesort
	{


		//Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.





		static void bubbleSort(int[] arr)
		{
			int n = arr.Length;
			for (int i = 0; i < n - 1; i++)
				for (int j = 0; j < n - i - 1; j++)
					if (arr[j] > arr[j + 1])
					{
						// swap temp and arr[i] 
						int temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
		}

		/* Prints the array */
		static void printArray(int[] arr)
		{
			int n = arr.Length;
			for (int i = 0; i < n; ++i)
				Console.Write(arr[i] + " ");
			Console.WriteLine();
		}

		// Driver method 
		//public static void Main()
		//{
		////	int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
		//int[] arr = { 29, 15, 0, 98, 0, 0, 99, 0 };
		//bubbleSort(arr);
		//	Console.WriteLine("Sorted array");
		//	printArray(arr);
		//}

	}

	// This code is contributed by Sam007 


}