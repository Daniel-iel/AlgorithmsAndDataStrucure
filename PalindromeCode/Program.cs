using System;
using System.Linq;

namespace PalindromeCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            var isPalindrome1 = Palindrome1("ababa");
            Console.WriteLine(isPalindrome1);

            var isPalindrome2 = Palindrome2("Atxta");
            Console.WriteLine(isPalindrome2);

            var isPalindrome3 = Palindrome3("ababa");
            Console.WriteLine(isPalindrome3);
        }

        public static bool Palindrome1(string str)
        {
            bool isPalindrome = true;
            int strLength = str.Length - 1;
            for (int i = 0; i <= strLength; i++)
            {
                if (str[i] != str[strLength - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }

        public static bool Palindrome2(string str)
        {
            var reversed = str.Reverse().ToArray();

            return str == new string(reversed);
        }

        public static bool Palindrome3(string str)
        {
            int index = 0;
            var listOfCaracters = str.ToList();

            return listOfCaracters.All(element =>
            {
                var compare = element == str[str.Length - index - 1];
                index++;
                return compare;
            });
        }
    }
}
