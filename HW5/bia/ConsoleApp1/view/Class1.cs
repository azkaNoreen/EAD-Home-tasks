using System;
using BO;
using BLL;

namespace view
{
	public class PersonView
	{


		public void Input()
		{
			Console.WriteLine("Enter Name:");
			string name = Console.ReadLine();
			Console.WriteLine("Enter Roll Number:");
			string roll = Console.ReadLine();
			Console.WriteLine("Enter Section:");
			string section = Console.ReadLine();
			Console.WriteLine("Enter Salary:");
			float salary = float.Parse(Console.ReadLine());
		
			PersonBO personbo = new PersonBO();
			personbo.name = name;
			personbo.roll = roll;
			personbo.section = section;
			personbo.salary = salary;
			PersonBLL bl = new PersonBLL();
			bl.save(personbo);

		}
		public void display()
		{
			PersonBLL bl = new PersonBLL();
			PersonBO personbo = bl.Read();
			Console.WriteLine("Name:" + personbo.name);
			Console.WriteLine("Roll No:" + personbo.roll);
			Console.WriteLine("Section:" + personbo.section);
			Console.WriteLine("Salary:" + personbo.salary);
			Console.WriteLine("Tax:" + personbo.tax);





		}




	}
}
