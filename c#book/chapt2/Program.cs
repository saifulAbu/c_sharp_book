using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace chapt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintSys();
            //char c = char.Parse("z");
            //patternMatch();
            // Console.ReadLine();
            // FormatHex();
            // FormatHex();
            // LocalVar();
            // ObjectType();
        }

        static void ObjectType()
        {
            Console.WriteLine("12.GetHashCode() : {0}, 12.Equals(23) : {1}, 12.ToString() : {2},  12.GetType() : {3}", 12.GetHashCode(), 12.Equals(23), 12.ToString(), 12.GetType());
            Console.WriteLine("{0} {1}", double.MinValue, double.Epsilon);
            Console.WriteLine("{0} {1}", bool.TrueString, bool.FalseString);
            Console.WriteLine("char: {0} {1} {2} {3} {4}", char.IsControl('\t'), char.IsDigit('9'), char.IsLetter('a'), char.ToLower('A'), char.ToLowerInvariant('Z'));
            double d = double.Parse("9.9999999");
            Console.WriteLine("double: {0}", d);
            bool.TryParse("True", out bool b);
            Console.WriteLine("bool: {0}", b);
        }

        static void patternMatch() 
        {
            string abc = "abc";

            if (abc is string mystr) { 
                Console.WriteLine("string is {0}", mystr);
            }

            var ch = ';';
            if (ch is int)
            {

            }
            else
            {
                 
            }

            int a = 1;
            if (a != 0 & (a = 5) != 3) {
                Console.WriteLine("value of a {0}", a);    
            }

            Console.WriteLine("value of a {0}", a);

            switch (a) { 
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                default: 
                    Console.WriteLine("default");
                    break;

            }
        }

        static void PrintSys() {
            Console.WriteLine("Os {0}", Environment.OSVersion);
            Console.WriteLine("Processors {0}", Environment.ProcessorCount);
            //Console.ReadLine();
            int.TryParse("abc", out int d);
            Console.WriteLine("{0}", d);
        }

        static void FormatHex() {
            string userMessage = string.Format("1000000 in hex is {0:X}", 100000);
            Console.WriteLine(userMessage);
        }
        static void LocalVar() {
            int myInt;
            string myString;
            myString = "my name is siddhartha saif";
            bool b1 = true, b2 = false, b3 = b1;

            System.Boolean b4 = false;

            myInt = default;

            myInt = new int();

            Console.WriteLine("default int {0}", myInt);
        }
    }
}
