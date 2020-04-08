using System;

namespace Problem2
{
    class Problem2Solution
    {
        static void Main(string[] args)
        {
            long num1 = 0;
            long num2 = 1;
            long result = 2;
            long sum = 0;

            while (result < 4000000)
            {
                result = num1 + num2;
                num1 = num2;
                num2 = result;

                if (result % 2 == 0)
                {
                    sum += result;
                    Console.WriteLine(result + ", ");
                }
            }
            Console.WriteLine("\nSum : " + sum);
        }
    }
}
