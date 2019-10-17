using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hello();
        }
       /* public static Double myFunction ()
        {

            double myResult = 0;
            return myResult;
        }*/
        public static void Hello ()
        {
            Console.WriteLine("Hello!");
        }
        public static void GreetByName ( string name)
        {
        Console.WriteLine($"Hello {name}");
        }
    }
}
