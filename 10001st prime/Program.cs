using System;

/*
10001st prime

By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10,001st prime number?
*/

namespace _10001st_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;

            for (int i = 1; i < 2000000; i++)
            {

                if (isPrime3(i))
                {

                    if (count == 10001)
                    {
                        Console.WriteLine("{0}", i);
                        break;
                    }

                    count++;
                }

            }
        }

        public static bool isPrime3(int number)
        {
            if (number < 2) return false;
            if (number % 2 == 0) return (number == 2);
            int root = (int)Math.Sqrt((double)number);
            for (int i = 3; i <= root; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

    }
}
