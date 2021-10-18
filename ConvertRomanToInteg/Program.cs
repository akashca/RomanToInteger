using System;
using System.Collections.Generic;

namespace ConvertRomanToInteg
{
    class Program
    {
        Dictionary<char, int> dict = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
        public int RomanToInt2(string s)
        {
            int res = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if (i + 1 < s.Length && dict[s[i]] < dict[s[i + 1]]) 
                {
                    res -= dict[s[i]];
                }
                else
                {
                    res += dict[s[i]];
                }
            }
            return res;
          
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Enter the Roman number");
            string input = Console.ReadLine();
            Console.WriteLine(obj.RomanToInt2(input)); 
        }
    }
}
