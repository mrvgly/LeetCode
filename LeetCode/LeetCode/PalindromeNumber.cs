using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            var tmp = x;
            var sum = 0;
            var mod = 0;
            while (tmp > 0)
            {
                mod = tmp % 10;
                tmp = tmp / 10;
                sum = sum * 10 + mod;
            }

            if (x == sum)
                return true;
            else
                return false;
        }
    }
}
