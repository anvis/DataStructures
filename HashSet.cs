using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
	// C# program to illustrate how to 
	// create hashset 
	using System;
	using System.Collections.Generic;
    using System.Diagnostics;

    class HashSet
	{

		// Main Method 
		//static public void Main()
		//{
		//	Get_Add_Performance_HashSet_vs_List();

		//	// Creating HashSet 
		//	// Using HashSet class 
		//	HashSet<string> myhash1 = new HashSet<string>();

		//	// Add the elements in HashSet 
		//	// Using Add method 
		//	myhash1.Add("C");
		//	myhash1.Add("C++");
		//	myhash1.Add("C#");
		//	myhash1.Add("Java");
		//	myhash1.Add("Ruby");
		//	myhash1.Add("C");     // duplicate is not inserted and no error occured in run time aswell.
		//	Console.WriteLine("Elements of myhash1:");
					

		//	// Accessing elements of HashSet 
		//	// Using foreach loop 
		//	foreach (var val in myhash1)
		//	{
		//		Console.WriteLine(val);
		//	}

		//	// Creating another HashSet 
		//	// using collection initializer 
		//	// to initialize HashSet 
		//	HashSet<int> myhash2 = new HashSet<int>() {10,
		//					100,1000,10000,100000};

		//	// Display elements of myhash2 
		//	Console.WriteLine("Elements of myhash2:");
		//	foreach (var valu in myhash2)
		//	{
		//		Console.WriteLine(valu);
		//	}
		//}


		static string[] names = new string[] {
		"Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
		"Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
		"GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
		"Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
		"Sabnis", "Leena", "Neema", "Sita" , "Tejas",
		"Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
		"Leena", "Neema", "Sita",
		"Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis"  };

		static void Get_Add_Performance_HashSet_vs_List()
		{

			Console.WriteLine("____________________________________");
			Console.WriteLine("List Performance while Adding Item");
			Console.WriteLine();
			List<string> lstNames = new List<string>();
			var s2 = Stopwatch.StartNew();
			foreach (string s in names)
			{
				lstNames.Add(s);
			}
			s2.Stop();

			Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
			Console.WriteLine("Ends Here");
			Console.WriteLine();
			Console.WriteLine("____________________________________");
			Console.WriteLine("HashSet Performance while Adding Item");
			Console.WriteLine();

			HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
			var s1 = Stopwatch.StartNew();
			foreach (string s in names)
			{
				hStringNames.Add(s);
			}
			s1.Stop();

			Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
			Console.WriteLine("Ends Here");
			Console.WriteLine("____________________________________");
			Console.WriteLine();

		}

	}

}
