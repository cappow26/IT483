using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
         * Answers to questions
         * 1. No because C# will convert it
         * 2. Yes because of order of operations it will not be calculated correctly based of how averages work
         * 3. Yes, average (double, double, double) will be used, it will convert all numbers do double since one of them is a double
         */

namespace weekdlab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 3, c = 5;
            double x = 2.2, y = 4.4, z = 6.6, ans;

            ans = average(a, b);
            Console.WriteLine("\naverage(a, b) = " + ans);

            ans = average(a, b, c);
            Console.WriteLine("\naverage(a, b, c) = " + ans);

            ans = average(x, y);
            Console.WriteLine("\naverage(x, y) = " + ans);

            ans = average(x, y, z);
            Console.WriteLine("\naverage(x, y, z) = " + ans);

            Console.Read();
        }

        public static double average(int n1, int n2)
        {
            return (n1 + n2) / 2.0;
        }

        public static double average(int n1, int n2, int n3)
        {
            return (n1 + n2 + n3) / 3.0;
        }

        public static double average(double n1, double n2)
        {
            return (n1 + n2) / 2.0;
        }

        public static double average(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3.0;
        }
    }
}