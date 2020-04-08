using System;

namespace Problem3
{
    class Problem3Solution
    {
        static void Main(string[] args)
        {
            const long n = 600851475143;
            long LargestPrimeFactor = 0;
            long[] Factors = new long[2];

            for (long i = 2; i *i < n; i++)
            {
                if (n % i == 0)
                {
                    Factors[0] = i;
                    Factors[1] = n / i;

                    for (int j = 0; j < 2; j++)
                    {
                        bool isPrime = true; 
                        for (long k = 2; k*k < Factors[j]; k++)
                        {
                            if (Factors[j] % k == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime && Factors[j] > LargestPrimeFactor)
                        {
                            LargestPrimeFactor = Factors[j];
                        }
                    }
                }
            }
            Console.WriteLine("The largest Prime Factor of " + n + " is : " + LargestPrimeFactor);
        }
    }
}
