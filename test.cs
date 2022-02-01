using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Reflection;
//using static System.Net.WebRequestMethods;

namespace ConsoleApp3
{
  class test
  {
	


	public dynamic ff(string config)
		{
			string file = "";
			var ret = true;
			string[] lines = File.ReadAllLines(file);


			return ret;
		}


		//public static void Main()
		//{

		//	PropertyInfo[] properties = typeof(Employee).GetProperties();
		//	foreach (PropertyInfo property in properties)
		//	{
		//		//property.SetValue(record, value);
		//	}




		//	List<Employee> e = new List<Employee>();
		//	e.Add(new Employee { Id = 1 });
		//	e.Add(new Employee { Id = 2 });
		//	e.Add(new Employee { Id = 1 });
		//	e.Add(new Employee { Id = 3 });

		//	List<Delivery> d = new List<Delivery>();
		//	d.Add(new Delivery { Id = 1, Employee = e });

		//	//	var result = d.

		//	foreach (var item in d)
		//	{

		//		List<Employee> distinct = item.Employee.Distinct().ToList();

		//		foreach (Employee value in distinct)
		//		{
		//			Console.WriteLine("After: {0}", value.Id);
		//		}




		//		item.Employee.Distinct();
		//	}

		//	Console.WriteLine("Sorted array");		
		//}
	}

	

	public class Delivery
	{
		public int Id { get; set; }
		public List<Employee>  Employee { get; set; }
	}

	public class Employee
	{
		public int Id { get; set; }
	}
}
