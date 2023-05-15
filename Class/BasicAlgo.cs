using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Code_Chanllenges
{
    public static class BasicAlgo
    {

        public static int Sumof(int num1, int num2)
        {
            if (num1 != num2)
            {
                var num3 = num1 + num2;
                return num3;
            }
            num1 = num1 * 3;
            return num1;
        }

        public static int ABSDiff(int n)
        {
            if (n < 51)
            {
                n = Math.Abs(n - 51);
                return n;
            }
            else
            {
                n = Math.Abs(n - 51);
                n = n * 3;
                return n;
            }
        }

        public static string Substring(string input)
        {
            if (input.Length >= 3)
            {
                var str2 = input.Substring(3);
                var res = str2 + "" + input + "" + str2;
                return res;
            }
            else
            {
                for (int i = 1; i < 3; i++)
                {
                    input = input + input;
                }
                return input;
            }
        }

        public static int[] IndexOFCapitals(string? str)
        {
            List<int> result = new List<int>();
            if (str!=null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsUpper(str[i]))
                    {
                        result.Add(i);
                    }
                }
            }
            return result.ToArray();
        }

         public static bool ValidatePIN(string str)
        {
            switch (str?.Length)
            {
                case 4:
                    return true;
                case 6:
                    return true;
                default:
                    return false;       
            }
        }
    }
}
