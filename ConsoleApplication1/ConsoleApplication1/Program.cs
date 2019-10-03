using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = new int[10];
            //Input(arr);
            DrawX2(5, 'X');
        }

        static void Input(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter value arr[{0}] =", i);
                arr[i] = int.Parse(Console.ReadLine());

            }
        }

        public static bool IsContains5(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsContains5or6(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5 || arr[i] == 6)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsContains5and6(int[] iArr)
        {
            bool found5 = false;
            bool found6 = false;
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 5)
                {
                    found5 = true;
                }
                for (int a = 0; a < iArr.Length; a++)
                {
                    if (iArr[a] == 6)
                    {
                        found6 = true;
                    }
                }
            }
            if (found5 == true && found6 == true)
            {
                return true;
            }
            return false;
        }
        public static int TestCount5(int[] Arr)
        {
            int c = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 5)
                {
                    c++;
                }
            }
            return c;
        }
        public static int TestCount5and6(int[] Arr)
        {
            int c = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 5 || Arr[i] == 6)
                {
                    c++;
                }
            }
            return c;

        }
        public static int Sum(int[] Arr)
        {
            int result = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                result += Arr[i];
            }
            return result;
        }
        public static void DrawX2(int n, char c = '*')
        {
            char[,] cArr = new char[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    cArr[i, j] = 'X';
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(cArr[i, j]);
                }
                Console.WriteLine();
            }



        }





    }
}
