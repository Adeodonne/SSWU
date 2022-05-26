using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector arr = new Vector(new int[5]);
            arr.RandomInitialization();
            Console.WriteLine(arr.ToString());
        }
    }
}
