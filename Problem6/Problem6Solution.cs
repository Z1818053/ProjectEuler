using System;

namespace Problem6
{
    class Problem6Solution
    {
        static void Main(string[] args)
        {
            int sumSquared = 0, SquaredSums = 0, Difference = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumSquared += i;
                SquaredSums += i * i;
            }

            Difference = (sumSquared * sumSquared) - SquaredSums;
            Console.WriteLine("The difference between the square of sum and sum of squares for 1 - 100 is " + Difference) ;
        }
    }
}
