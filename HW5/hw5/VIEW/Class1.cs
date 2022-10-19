using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using BLL;
namespace VIEW
{
    public class personView
    {
        public void input()
        {
            System.Console.WriteLine("Enter your name, please!");
            String Name= Console.ReadLine();
            System.Console.WriteLine("Enter your rollNumber,");
            String rollNum = Console.ReadLine();
            System.Console.WriteLine("Enter your Degree,");
            String Degree = Console.ReadLine();
            System.Console.WriteLine("Enter your Salary,");
            float Salary = float.Parse(Console.ReadLine());

            personBO person = new personBO(Name, rollNum, Degree, Salary);
            personBLL personB = new personBLL();
            personB.Save(person);

        }
        public void display()
        {
            personBLL personB = new personBLL();
            personBO person = personB.Read();
            System.Console.WriteLine(person.show());


        }
    }
}
