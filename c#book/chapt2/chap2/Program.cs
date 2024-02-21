using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
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
            // DateTimeex();
            // StringExperiment();
            // StringEql();
            //ProcessByte();
            // LinqQuery();
            // Looping();
            // IfElse();
            // SwitchCase();
            Color('y');

        }

        private static void Color(char colorband) {
            string color = null;

            color = colorband switch
            {
                'v' => "violet",
                'i' => "indigo",
                'b' => "blue",
                'g' => "green",
                'y' => "yellow",
                'o' => "orange",
                'r' => "red",
                _ => "unknown"
            };

            Console.WriteLine(color);
        }

        private static void SwitchCase()
        {
            int choice = 1;
            switch (choice)
            {
                case 0:
                    Console.WriteLine("case 0");
                    break;
                case 1:
                    Console.WriteLine("case 1");
                    goto case 4;
                case 2:
                    Console.WriteLine("case 2");
                    goto case default;
                case 3:
                    
                case 4:
                    Console.WriteLine("case 4");
                    break;
                default:
                    Console.WriteLine("default case");
                    break;
            }
        }

        private static void IfElse()
        {
            string buddha = "i take refuge to the buddha!";

            if (buddha.Length > 0)
            {
                Console.WriteLine(buddha);
            }
            else
            {
                Console.WriteLine("sugata");
            }

            int value = 01_000;

            if (value is int nemoValue)
            {
                Console.WriteLine($"here is my value {nemoValue}");
            }

            object testItem = 123;
            Type t = typeof(string);
            char c = 'c';
            if (t is Type) 
            {
                Console.WriteLine($"{t} is a type");
            }

            if (c is >= 'a' and < 'z' or >= 'A' and < 'Z') 
            {
                Console.WriteLine("thinking about it was the hard part!");
            }
        }

        private static void Looping()
        {
            for (int i = 0; i < 10; i++) 
            { 
                Console.WriteLine(i);
            }

            string[] cars = { "tesla", "audi", "bmw", "toyota", "honda" };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            int choice = 1;

            while (choice != 1) 
            { 
                Console.WriteLine("in while");
                Console.WriteLine("are you done? [0] no [1] yes");
                choice = int.Parse(Console.ReadLine());
            }

            // do while
            do 
            {
                Console.WriteLine("in do while");
                Console.WriteLine("are you done? [0] no [1] yes");
                choice = int.Parse(Console.ReadLine());
            } while (choice != 1);
        }

        static void LinqQuery()
        {
            int[] numbers = { 10, 30, 20, 40, 1, 2, 3, 8 };
            
            var subset = from i in numbers where i > 10 select i;

            Console.WriteLine("values in subset {0}", subset);

            foreach (var i in subset) 
            { 
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
            
            Console.WriteLine("Subset is of type {0}", subset.GetType().Name);

            Console.WriteLine("Subset is defined in {0}", subset.GetType().Namespace);

        }

        static void ProcessByte() {
            byte b1 = 100, b2 = 100;

            byte c1 = checked((byte)Add(b1, b2));
        }

        static int Add(int i, int j)
        {
            return i + j;
        }

        static void StringEql() 
        {
            string s1 = "hello";
            Console.WriteLine(s1 == "hello");
            Console.WriteLine(s1 == "Hello");
            
            Console.WriteLine(s1.CompareTo("hello"));
            Console.WriteLine(s1.CompareTo("Hello"));
            Console.WriteLine("Hello".CompareTo("hello"));

            Console.WriteLine(s1.Equals("hello"));
            Console.WriteLine(s1.Equals("Hello"));

            string s2 = "HELLO";

            Console.WriteLine();
            Console.WriteLine(s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));

            //Console.WriteLine(s1.Equals("hello"));
            //Console.WriteLine(s1.Equals("Hello"));






        }

        static void StringExperiment()
        {
            string str0 = "priyota is my spouse and love, i take refuge to her!";

            string str1 = str0.Replace("priyota", "buddha");

            string str3 = str1.Replace("her", "him");

            Console.WriteLine(str3);

            Console.WriteLine("string interpolation");

            string str = string.Format("{0} kierkgard says no matter what you do, you {1}", "soren", "regret");

            Console.WriteLine(str);

            string bdh = "buddha";

            string ws = "wise";

            string strb = $"{bdh} says suffering has an end given you act {ws}";

            Console.WriteLine(strb);

            Console.WriteLine("string interpolator  class");

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(bdh);
            stringBuilder.Append(" is my spouse");
            stringBuilder.Append(" buddha and mara lives in me");
            stringBuilder.Append(" without right action, life is dull");

            Console.WriteLine(stringBuilder);

            string verb = @"
                what is in life 
                        if there is 
                                no peace!
                peace is the highest happiness!!!!

            ";

            Console.WriteLine(verb);


        }

        static void DateTimeex() { 
            DateTime dt = new DateTime(1986, 12, 25);
            Console.WriteLine("The day of week {0} day of year {1} day {2}", dt.DayOfWeek, dt.DayOfYear, dt.Day);
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
