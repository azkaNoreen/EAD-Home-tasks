using System;

namespace Boxing
{
    class BnU
    {
        static void Main(string[] args)
        {
            //Boxing
            int a = 234;
            object o = a;
            a = 6;
            //UNboxing
            int c = (int)o;
            Console.WriteLine("Value of a is " + a);
            Console.WriteLine("Value of O is " + o + " , C is " + c);

            //COnvert STring to int
            int z = Convert.ToInt32(Console.ReadLine());

            object in= x;
            x = 300;
            Console.WriteLine(z);
            Console.WriteLine(x);


            Console.ReadKey();
        }
    }
}
