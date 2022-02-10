using System;

namespace fundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 256) {
                Console.WriteLine(i);
                i = i + 1;
            }
            
            for (int j = 1; j < 256; j = j + 1)
            {
                Console.WriteLine(j);
            }

            int k = 1;
            while (k < 101)
            {
                if (k % 3 == 0 && k % 5 == 0)
                {
                    Console.WriteLine("");
                }

                else if (k % 3 == 0 || k % 5 == 0)
                {
                    Console.WriteLine(k);
                }

                k = k + 1;
            }

            for (int l = 1; l <= 100; l = l + 1)
            {
                if (l % 3 == 0 && l % 5 == 0)
                {
                    Console.WriteLine("");
                }
                else if (l % 3 == 0 || l % 5 == 0) 
                {
                    Console.WriteLine(l);
                }
            }

            int m = 1;
            while (m <= 100)
            {
                if (m % 3 == 0 && m % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (m % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (m % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                m = m + 1;
            }

            for (int n = 1; n <= 100; n = n + 1)
            {
                if (n % 3 == 0 && n % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (n % 3 == 0) 
                {
                    Console.WriteLine("Fizz");
                }
                else if (n % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}
