using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace chapt2.chap4
{
    internal class chap4
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hola, mundo!");
            //SimpleArrays();
            // ArrayOfObjects();
            //RectMultiDimArr();
            //JaggedArray();
            // ArrayArgs();
            //ArrayFunc();
            //Console.WriteLine("result of fun in fun {0}", InnerFunction(10, 20));
            //CallerExpMeth();
            //MethExpParamsCaller();
            //OptionalParams("saif");
            //OptionalParams("siddhartha", "trained");
            //NamedParmas("sid", "saif");
            //NamedParmas(last: "saif", first: "sid");
            //OverLoading(1, 2);
            //OverLoading((int) 1.0f, (int) 2.0f);
            //ArgNull("buddha", 0);
            //ArgNull(null, 0);
        }

        enum MindTypeEnum { 
            Untrained,
            SemiTrained,
            Trained,
            Fullyenlightened
        }

        private static void ArgNull(string arg, int v)
        {
            if (v == 0)
            {
                if (arg == null)
                {
                    throw new ArgumentNullException(arg);
                }
            }
        }

        private static void OverLoading(int x, int y)
        { 
            Console.WriteLine("int version called");
        }

        private static void OverLoading(double x, double y)
        {
            Console.WriteLine("double version called");
        }
        private static void NamedParmas(string first, string last)
        {
            Console.WriteLine($"firstName: {first}, lastName: {last}");
        }

        private static void OptionalParams(string name, string type="untrained")
        {
            Console.WriteLine($"{name} has an {type} mind");
        }

        private static void MethExpParamsCaller()
        {
            int res = MethExpParams(1, 2, 3, 4);
            Console.WriteLine($"first sum is {res}");

            res = 0;

            res = MethExpParams([1, 2, 3, 4]);
            Console.WriteLine($"second sum is {res}");

            res = 0;
            res = MethExpParams(new int[] {1, 2, 3, 4});
            Console.WriteLine($"third sum is {res}");


        }

        private static int MethExpParams(params int[] arr)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                res += arr[i];
            }
            return res;
        }

        private static void CallerExpMeth()
        { 
            int x = 0;
            int y = 0;
            ExpMethodsNoRef(x, y);

            System.Console.WriteLine($"after calling no ref method {x} and {y}");
            int z = 0;
            ExpMethodsOut(x, y, out z);

            System.Console.WriteLine($"after calling no ref method x: {x} and y: {y} and z: {z}");

            z = -9;
            //call with discard
            ExpMethodsOut(x, y, out _);

            System.Console.WriteLine($"after calling no ref method x: {x} and y: {y} and z: {z}");

            string saif = "saif";
            string nemo = "nemo";

            Console.WriteLine($"before call ExpMethodRef saif: {saif}, nemo: {nemo}");
            ExpMethodRef(ref saif, ref nemo);
            Console.WriteLine($"after call ExpMethodRef saif: {saif}, nemo: {nemo}");
            
            x = 5; y = 2;
            ExpMethodIn(in x, in y , out z);
            System.Console.WriteLine($"after calling ExpMethodInmethod x: {x} and y: {y} and z: {z}");

        }

        private static void ExpMethodIn(in int x, in int y, out int z)
        {
            z = x + y;
        }


        private static void ExpMethodRef(ref string s0, ref string s1)
        {
            string temp;
            temp = s0;
            s0 = s1;
            s1 = temp;
        }

        private static void ExpMethodsNoRef(int x, int y)
        {
            x = 10;
            y = 20;
        }

        private static void ExpMethodsOut(int x, int y, out int res)
        {
            x = 10;
            y = 20;
            res = x + y;
        }

        private static int InnerFunction(int x, int y)
        {
            int temp = Add(x, y);
            return temp * 0; // everything causes suffering and eveuntually everything leads to zero

            static int Add(int x, int y) { 
                return x + y;
            }
        }

        private static void IndexPlay()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

           // var p = arr[0..2];

        }
        private static void ArrayFunc()
        {
            char[] arr = ['a', 'b', 'c', 'd'];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Array.Reverse(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();


            Array.Clear(arr, 1, 3);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        private static void ArrayArgs()
        {
            int[] arr = GetArr();
            PrintArr(arr);
        }

        private static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();    
        }

        private static int[] GetArr()
        {
            int[] retArr = new int[10];
            for (int i = 0; i < retArr.Length; i++)
            {
                retArr[i] = i;
            }
            return retArr;
        }

        static void JaggedArray ()
        {

            int[][] jag;
            jag = new int[5][];

            for (int i = 0; i < jag.Length; i++)
            {
                jag[i] = new int[i + 1];
            }

            int val = 0;
            for (int r = 0; r < jag.Length; r++) 
            { 
                for (int c = 0; c < jag[r].Length; c++) 
                {
                    jag[r][c] = val++;
                }
            }

            for (int r = 0; r < jag.Length; r++)
            {
                for (int c = 0; c < jag[r].Length; c++)
                {
                    Console.Write(jag[r][c] + " ");
                }
                Console.WriteLine();
            }
        }

        static void RectMultiDimArr()
        {
            int[,] matrix;
            matrix = new int[3,4];

            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 4; c++) 
                {
                    matrix[r, c] = r * c;
                }
            }

            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(matrix[r, c] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(matrix.Length);

            int[,,,] multarr = new int[1, 2, 3, 4];

            Console.WriteLine("dimension: " + multarr.Rank);
            for (int dim = 0; dim < multarr.Rank; dim++) {
                Console.WriteLine($"dimension {dim} length {multarr.GetLength(dim)}");
            }

        }

        static void ArrayOfObjects()
        {
            object[] array = new object[4];
            array[0] = 1;
            array[1] = false;
            array[2] = new DateTime(1986, 12, 25);
            array[3] = "all there is only suffering!";

            foreach (object item in array)
            {
                Console.WriteLine($"{item.ToString()} is of type: {item.GetType()}");
            }
        }

        static void SimpleArrays() {
            int[] myint = new int[3];
            string[] bookOnDotNet = new string[100];

            myint[0] = 100;
            myint[1] = 200;
            myint[2] = 300;

            foreach(int i in myint)
            {
                Console.WriteLine($"{i}");
            }

            bookOnDotNet = ["book1", "book2", "book3"];

            foreach (string s in bookOnDotNet)
            { 
                Console.WriteLine (s);
            }

            //initing with size + default values
            myint = [1, 2, 3];

            foreach (int i in myint)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
