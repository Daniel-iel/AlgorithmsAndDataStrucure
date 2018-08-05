using System;
using System.Collections;
using System.Linq;

namespace StringReversalCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var reversed1 = reverse1("Daniel");
            Console.WriteLine(reversed1);

            var reversed2 = reverse2("Daniel");
            Console.WriteLine(reversed2);

            var reversed3 = reverse3("Daniel");
            Console.WriteLine(reversed3);
        }

        static string reverse1(string str)
        {
            var arr = str.Reverse().ToArray();

            return new string(arr);
        }

        static string reverse2(string str)
        {
            string reversed = "";
            foreach (var value in str)
                reversed = value + reversed;

            return reversed;
        }

        static string reverse3(string str)
        {
            //string reversed = "";

            //var arr = str.ToArray();
            //var teste = arr.Aggregate((a , b) => b  );

            return "";
        }     
    }
}
