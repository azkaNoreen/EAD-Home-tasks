using System;
namespace Events
{
    public delegate void myDel();
    class Program
    {
        public static event myDel Mevent;
        public static void Family()
        {
            Console.WriteLine("Family");
        }
        public static void Friends()
        {
            Console.WriteLine("Friends");
        }
        public static void ClassFellows()
        {
            Console.WriteLine("Class Fellows");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Azka Noreen");
            Console.WriteLine("BSEF19M502");
            Mevent += new myDel(Family);
            Mevent += new myDel(Friends);
            Mevent += new myDel(ClassFellows);
            Mevent.Invoke();
            Console.ReadKey();
        }
    }}


