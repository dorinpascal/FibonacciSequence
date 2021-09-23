using System;
using System.Diagnostics;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine(fib2(11));
        }

        static int fib(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            return fib(n - 1) + fib(n - 2);
        }


        static int fib2(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            int sLast = 0;
            int last = 1;
            int curPos = 2;

            while(curPos<=n)
            {
                int temp = last;
                last += sLast;
                sLast = temp;
                curPos++;
            }
            return last;

        }
    }
}
