using System;

namespace _09_Ex
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 3, 2 }, { 1, 4 } };
            int[,] b = new int[,] { { 9, 2 }, { 1, 7 } };

            Print(a, "A");
            Console.WriteLine();
            Print(name: "B", array: b);
            Console.WriteLine();

            int[,] c = Calc(a, b);
            Print(c, "C");
        }

        private static int[,] Calc(int[,] a, int[,] b)
        {
            int[,] c = new int[2, 2];

            c[0, 0] = a[0, 0] * b[0, 0];
            c[0, 1] = a[0, 1] * b[1, 0];
            c[1, 0] = a[1, 0] * b[0, 1];
            c[1, 1] = a[1, 1] * b[1, 1];

            return c;
        }

        private static void Print(int[,] array, string name)
        {
            Console.WriteLine("{0} = ", name);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0} ", array[i,j]);
                }

                Console.WriteLine();
            }
        }
    }
}
