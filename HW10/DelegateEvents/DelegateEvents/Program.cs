using System;

namespace DelegateEvents
{
    public delegate String MyDelagate(String mydelegateString);
    class Program
    {
        event MyDelagate myevent;
        public Program()
        {
            this.myevent += new MyDelagate(this.hi);
        }
        public String hi(String name)
        {
            return "Hi, " + name;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Azka Noreen");
            Console.WriteLine("BSEF19M502");
            Program myProg = new Program();
            String result = myProg.myevent("Azka Noreen");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
