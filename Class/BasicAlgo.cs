using System;
using System.Collections.Generic;
using System.Linq;
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
            if (n<51) {
                n = Math.Abs(n-51);
                return n;
            } else {
                n = Math.Abs(n-51);
                n = n*3;
                return n;
            }
        }
    }
}
