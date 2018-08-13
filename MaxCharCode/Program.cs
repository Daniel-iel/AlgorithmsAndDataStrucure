using System;
using System.Collections.Generic;

namespace MaxCharCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            maxChar("Hello World!");
        }

        public static char maxChar(string str)
        {
            var charMap = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (charMap.ContainsKey(character))
                    charMap[character]++;
                else
                    charMap.Add(character, 1);
            }

            char letter = ' ';
            int charCount = 0;

            foreach (var character in charMap)
            {
                if (charMap[character.Key] <= charCount)
                    continue;

                letter = character.Key;
                charCount = charMap[character.Key];
            }

            return letter;
        }
    }
}
