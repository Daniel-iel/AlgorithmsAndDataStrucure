using System;

namespace CapitalizeCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string Captalize1(string str)
        {
            string result = str[0].ToString().ToUpper();

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] == ' ')
                {
                    result += str[i].ToString().ToUpper();
                }
                else
                {
                    result += str[i];
                }
            }

            return result;
        }      
    }
}
