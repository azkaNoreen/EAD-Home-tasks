using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void Calculations(int a, int b);

        public static void addition(int a, int b)
        {
            Console.WriteLine("Sum of the given numbers is:"+( a + b));
        }
        public static void subtraction(int a, int b)
        {
            Console.WriteLine("Subtraction of the given numbers is:"+( a - b));
        }
        public static void division(int a, int b)
        {
            Console.WriteLine("Division of the given numbers is:"+( a / b));
        }
        public static void multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication of the given numbers is:"+( a * b));
        }
        public static void mod(int a, int b)
        {
            Console.WriteLine("MOdulus of the given numbers is:"+ (a % b));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zainab Bibi");
            Console.WriteLine("Software Engineering");
            Console.WriteLine("BSEF19M538");

            Console.WriteLine("Enter first number: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int n2 = int.Parse(Console.ReadLine());

            Calculations dlg = new Calculations(addition);
            dlg(n1, n2);
            dlg = subtraction;
            dlg(n1, n2);

            dlg = division;
            dlg(n1, n2);

            dlg = multiplication;
            dlg(n1, n2);

            dlg = mod;
            dlg(n1, n2);

            Console.ReadKey();}
    }
}
