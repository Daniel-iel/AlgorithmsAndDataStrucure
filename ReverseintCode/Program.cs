using System;
using System.Linq;

namespace ReverseintCode
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public int Reverseint(int n)
        {
            var reversed = n.ToString().Replace("-","") .Reverse().ToArray();
            var stringReversed = new string(reversed);

            return int.Parse(stringReversed) * Math.Sign(n);
        }
    }
}
