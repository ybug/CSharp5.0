using System;
using System.Collections;

namespace _2DArray
{
    class MyList/* : IEnumerable, IEnumerator*/
    {
        private int[] array;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get
            {
                return array.Length;
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            //int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            //foreach (var items in arr)
            //{
            //    Console.WriteLine(items);
            //}

            //JaggedArray();
            Indexer();
        }

        private static void Indexer()
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
            {
                list[i] = i;
            }

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        static void JaggedArray()
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10, 20, 30 };
            jagged[2] = new int[] { 100, 200 };

            foreach (int[] arr in jagged)
            {
                Console.Write("Length : {0}, ", arr.Length);

                foreach (int e in arr)
                {
                    Console.Write("{0} ", e);
                }

                Console.WriteLine();
            }
        }
    }
}
