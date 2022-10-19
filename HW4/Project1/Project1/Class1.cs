using System;
using FSpace;
using SSpace;

/// <summary>
/// Summary description for Class1
/// </summary>
	namespace FSpace
{
	public class abc
    {
        public void Show()
        {
            Console.WriteLine("From First Name Space");
        }
    }
}
namespace SSpace
{
    public class xyz
    {
        public void Show()
        {
            Console.WriteLine("From Second Name Space");
        }
    }
}
class Test { 
    static void Main(String[] args)
    {
        abc v = new abc();
        xyz w = new xyz();
        v.Show();
        w.Show();
        Console.ReadKey();
    }
}