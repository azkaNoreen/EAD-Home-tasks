
using System;
using System.IO;
using BO;
namespace DAL
{
	public class PersonDAL
	{
		public PersonBO read()

		{
			PersonBO personbo = new PersonBO();
			FileStream fout = new FileStream("data.txt", FileMode.Open);
			StreamReader sr = new StreamReader(fout);
			string line =sr.ReadLine();
			string[] data = line.Split(',');
			personbo.name = data[0];
			personbo.roll = data[1];
			personbo.section = data[2];
			personbo.salary = float.Parse(data[3]);
			personbo.tax = float.Parse(data[4]);
			
			fout.Close();
			sr.Close();
			return personbo;
		}

		public void save(PersonBO bo)
		{
			FileStream fin = new FileStream("data.txt", FileMode.Create);
			StreamWriter sw = new StreamWriter(fin);
			sw.WriteLine(bo.name +","+ bo.roll + "," + bo.section + "," + Convert.ToString(bo.salary)+ "," + Convert.ToString( bo.tax));
			sw.Close();
			fin.Close();		  
	 }
	}
}