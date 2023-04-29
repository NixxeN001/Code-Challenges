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
    }
}
