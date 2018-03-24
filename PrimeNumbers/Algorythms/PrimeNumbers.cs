<<<<<<< HEAD
﻿using System;
using System.Threading;

namespace MetroFramework_test_at_a_new_project.Algorythms
{
    public static class PrimeNumbers
    {
        public static int[] GenerateInt(int n)
        {
            var res = new int[n];

            Thread.Sleep(20000);
            return res;
        } 

        public static string[] GenerateStr(int n) => new[]
        {
            1.ToString(),
            2.ToString(),
            3.ToString(),
            5.ToString(),
            7.ToString(),
            11.ToString(),
            13.ToString(),
            17.ToString(),
            19.ToString(),
            23.ToString(),
            29.ToString()
        };
    }
}
=======
﻿namespace MetroFramework_test_at_a_new_project.Algorythms
{
    public static class PrimeNumbers
    {
        static int k = 0;
        public static int Is_prime(int n)
        {

            int i;
            for (i = 2; i * i <= n; ++i)
            {
                if (n % i == 0) { return 0; }
            }
            return 1;
        }

        static public int next_prime(int n)
        {
            do
            {
                ++n;
            } while (Is_prime(n) == 0);
            return n;
        }


        public static int[] Prim(int k)
        {
            int[] GenerateInt = new int[k];

            int n = 2;
            int i = 0, nm = k;
            
            for (i = 0; i < nm; ++i)
            {
                GenerateInt[i] = n;
                n = next_prime(n);

            }
            return GenerateInt;
        }

    }
}
>>>>>>> 6edb5c5ddbfec3c03b56018e462a655396ac6e72
