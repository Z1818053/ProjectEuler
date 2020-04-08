using System;

namespace ProjectEuler
{
    class Problem1Solution
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                bool check = isMultiple(i);


                if (check)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

        static bool isMultiple(int currentIndex)
        {
            bool check = currentIndex % 3 == 0 || currentIndex % 5 == 0;
            return check;
        }
    }
}