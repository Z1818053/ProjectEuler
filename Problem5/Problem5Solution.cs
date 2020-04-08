using System;

namespace Problem5
{
    class Problem5Solution
    {
        static void Main(string[] args)
        {
            long counter = 1, result = 0;
            bool smallestMultiple = false;

            while (!smallestMultiple)
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (counter % i == 0)
                    {
                        smallestMultiple = true;
                        result = counter;
                    }
                    else
                    {
                        smallestMultiple = false;
                        counter++;
                        break; 
                    }
                }
            }

            Console.WriteLine("The Smallest Multliple divible by 1 - 20 is: " + result);
            
        }
    }
}
