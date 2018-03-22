using System;
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