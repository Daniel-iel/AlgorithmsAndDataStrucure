using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AnagramCode
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Anagram1("!Daniel 12", "21 Daniel! ");

            Console.WriteLine("Hello World!");
        }

        public static bool Anagram1(string strA, string strB)
        {
            Regex reg = new Regex(@"\s+");

            strA = reg.Replace(strA, "").ToLower();
            strB = reg.Replace(strB, "").ToLower();

            if (strA.Length != strB.Length)
            {
                return false;
            }

            var aCharMap = new Dictionary<char, int>();
            var bCharMap = new Dictionary<char, int>();

            foreach (var letter in strA)
            {
                if (aCharMap.ContainsKey(letter))
                    aCharMap[letter]++;
                else
                    aCharMap.Add(letter, 1);
            }

            foreach (var letter in strB)
            {
                if (bCharMap.ContainsKey(letter))
                    bCharMap[letter]++;
                else
                    bCharMap.Add(letter, 1);
            }

            foreach (var letter in strA)
            {
                if (!aCharMap.ContainsKey(letter) && !bCharMap.ContainsKey(letter))
                    return false;
                else
                    if (aCharMap[letter] != bCharMap[letter])
                    return false;
            }

            return true;
        }

        public static bool Anagram2(string strA, string strB)
        {
            var aCharMap = buildMap(strA);
            var bCharMap = buildMap(strB);

            if (!aCharMap.ContainsKey(bCharMap.Select(c => c.Key)))
                return false;

            foreach (var letter in aCharMap)
            {
                if (aCharMap[letter.Key] != bCharMap[letter.Key])
                    return false;
            }

            return true;
        }

        private static Dictionary<char, int> buildMap(string str)
        {
            var strMap = new Dictionary<char, int>();

            Regex reg = new Regex(@"\s+");
            str = reg.Replace(str, "").ToLower();

            foreach (var letter in str)
            {
                if (strMap.ContainsKey(letter))
                    strMap[letter]++;
                else
                    strMap.Add(letter, 1);
            }

            return strMap;
        }

        private static bool ContainsKey(this Dictionary<char, int> dic, IEnumerable<char> keys)
        {
            foreach (var key in keys)
            {
                if (!dic.ContainsKey(key))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool Anagram3(string strA, string strB)
        {
            return CleanStr(strA) == CleanStr(strB);
        }

        private static string CleanStr(string str)
        {
            return string.Concat(new Regex(@"\s+").Replace(str, "").ToLower().OrderBy(x => x));
        }
    }
}
