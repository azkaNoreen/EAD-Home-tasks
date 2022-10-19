using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIEW;
namespace hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N tier architecture....");
            personView person = new personView();
            person.input();
            person.display();
            System.Console.ReadKey();

        }
    }
}
