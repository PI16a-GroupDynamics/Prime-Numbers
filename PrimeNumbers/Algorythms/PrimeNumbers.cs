using System;
using JetBrains.Annotations;

namespace MetroFramework_test_at_a_new_project.Algorythms
{
    public static class PrimeNumbers
    {
        public static int Is_prime(long n)
        {
            long i;
            for (i = 2; i * i <= n; ++i)
            {
                if (n % i == 0)
                {
                    return 0;
                }
            }

            return 1;
        }

        public static long Next_prime(long n)
        {
            do
            {
                ++n;
            } while (PrimeNumbers.Is_prime(n) == 0);

            return n;
        }


        [NotNull]
        public static long[] GenerateInt(int k)
        {
            if (k < 0)
            {
                throw new ArgumentException(@"Количество не может быть <0", nameof(k));
            }
            var generateInt = new long[k];

            long n = 2;
            int i,
                nm = k;

            for (i = 0; i < nm; ++i)
            {
                generateInt[i] = n;
                n              = PrimeNumbers.Next_prime(n);
            }

            return generateInt;
        }
    }
}