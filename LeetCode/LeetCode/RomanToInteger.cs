using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            if (s.Length < 0 || s.Length > 15)
                return -1;

            if (s.All(c => (c == 'I' || c == 'V' || c == 'X' || c == 'L' || c == 'C' || c == 'D' || c == 'M')))
                return -1;

            int result = 0;

            var dict = new Dictionary<char, int> {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && dict[s[i]] < dict[s[i + 1]])
                {
                    result -= dict[s[i]];
                }
                else
                {
                    result += dict[s[i]];
                }
            }

            return result;
        }
    }
}