using System;
using System.Linq;

namespace ReverseintCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Reverseint(36235);
        }

        public static int Reverseint(int n)
        {
            var reversed = n.ToString().Replace("-","") .Reverse().ToArray();
            var stringReversed = new string(reversed);

            return int.Parse(stringReversed) * Math.Sign(n);
        }

        public static int Reverseint1(int n)
        {
            int remaing = 0;

            while (Math.Abs(n) > 0)
            {
                remaing = remaing * 10 + (n % 10);

                n = n / 10;
            }

            return remaing;
        }
    }
}
