using System;

namespace Fibonacci
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            //In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + a;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int length = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Fibonacci(length));
            Console.ReadKey();
        }
    }
}
