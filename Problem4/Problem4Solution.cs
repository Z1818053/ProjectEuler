using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem4
{
    class Problem4Solution
    {
        static void Main(string[] args)
        {
            long LargestPalindrome = 0, result = 0;
            var product = "";
            long[] Factors = new long[2];
            for(int i = 100; i <= 999; i++)
            {
                for (int j = 100; j < 999; j++)
                {
                    product = Convert.ToString(i * j);

                    if (product == new String(product.Reverse().ToArray()))
                    {
                        if(Convert.ToInt64(product) > result)
                        {
                            result = Convert.ToInt64(product);
                            Factors[0] = i;
                            Factors[1] = j;
                        }
                    }
                }
            }

            LargestPalindrome = result;
            Console.WriteLine("X: " + Factors[0] + " Y: " + Factors[1] + " Palindrome " + LargestPalindrome);

        }
    }
}
