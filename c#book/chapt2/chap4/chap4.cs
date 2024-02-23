using System;
using System.Collections.Generic;
using System.Linq;
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
            ArrayArgs();
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
