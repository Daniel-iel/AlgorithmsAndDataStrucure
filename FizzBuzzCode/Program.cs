using System;

namespace FizzBuzzCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(15);
        }

        public static string[] FizzBuzz(int n)
        {
            var result = new string[n+1];

            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result[i] = "fizzbuzz";
                else if (i % 3 == 0)
                    result[i] = "fizz";
                else if (i % 5 == 0)
                    result[i] = "buzz";
                else
                    result[i] = i.ToString();
            }

            return result;
        }
    }
}
