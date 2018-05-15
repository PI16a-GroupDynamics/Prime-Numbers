using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroFramework_test_at_a_new_project
{
    public static class Extensions
    {
       public static bool BoolCustomTryParse(string value, out bool result)
        {
            switch (value.ToLower())
            {
                case @"да":case "yes":case "1":case"true":
                    result = true;
                    return true;
                case @"нет":case "no":case "0":case"false":
                    result = false;
                    return true;
                default:
                    result = false;
                    return false;
            }
        }
    }
}
